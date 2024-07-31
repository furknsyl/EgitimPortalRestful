using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using EgitimPortal.Application.Exceptions;
using FluentValidation;
using EgitimPortal.Application.Behaviors;
using MediatR;
using System.Globalization;
using EgitimPortal.Application.Features.Products.Rules;
using EgitimPortal.Application.Bases;

namespace EgitimPortal.Application
{
    public static class Registration
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddTransient<ExceptionMiddleWare>();

            services.AddRulesFromAssemblyContaining(assembly, typeof(BaseRules));

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

            services.AddValidatorsFromAssembly(assembly);
            ValidatorOptions.Global.LanguageManager.Culture = CultureInfo.InvariantCulture;


            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(FluentValidationBehavior<,>));


        }

        private static IServiceCollection AddRulesFromAssemblyContaining(
            this IServiceCollection services,
            Assembly assembly,
            Type type)
        {
            var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
            foreach (var item in types)
                services.AddTransient(item);

            return services;
        }
    }
}
