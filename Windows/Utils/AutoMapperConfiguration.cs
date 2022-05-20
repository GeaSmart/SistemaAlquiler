using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Utils
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(config => {
                config.AddProfile<MappingProfile>();
                //config.ValidateInlineMaps = false;
                }
            );
            Mapper.AssertConfigurationIsValid();
        }
    }
}
