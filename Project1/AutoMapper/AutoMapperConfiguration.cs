using global::AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.AutoMapper
{
    public static class AutoMapperConfiguration
    {
        public static void Config()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
        }
    }
}
