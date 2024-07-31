using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Application.Interfaces.AutoMapper;
using IMapper = EgitimPortal.Application.Interfaces.AutoMapper.IMapper;

namespace EgitimPortalMapper
{
    public static class Registration
    {
        public static void AddCustomMapper(this IServiceCollection services)
        {
            services.AddSingleton<IMapper, AutoMapper.Mapper>();
        }

    }
}
