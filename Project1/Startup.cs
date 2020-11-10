using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Project1.AutoMapper;
using Project1.DAL.Database;
using Project1.Repository.UnitOfWork;
using Project1.Services.CategoryService;
using Project1.Services.FollowingRelationshipService;
using Project1.Services.PostCategoryService;
using Project1.Services.PostCommentService;
using Project1.Services.PostLikeService;
using Project1.Services.PostService;
using Project1.Services.UserProfileService;
using Project1.Services.UserService;

namespace Project1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            AutoMapperConfiguration.Config();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddMvc();
            services.AddControllers();
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("project", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Project I",
                    Description = "SOICT",
                    Contact = new OpenApiContact()
                    {
                        Name = "Dang Phu Khang",
                        Email = "dangphukhang2742000@gmail.com"
                    }
                });
            });
            // services.AddMvc();
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(
                Configuration.GetConnectionString("DefaultConnection")));
            // services.AddSingleton<DatabaseContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IPostLikeService, PostLikeService>();
            services.AddScoped<IPostCommentService, PostCommentService>();
            services.AddScoped<IFollowingRelationshipService, FollowingRelationshipService>();
            services.AddScoped<IUserProfileService, UserProfileService>();
            services.AddScoped<IPostCategoryService, PostCategoryService>();
            services.AddScoped<ICategoryService, CategoryService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, DatabaseContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/project/swagger.json", "My API V1");
            });

            DbInitializer.Initialize(context);
        }
    }
}
