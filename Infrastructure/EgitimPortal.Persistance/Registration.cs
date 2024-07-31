using EgitimPortal.Persistance.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimPortal.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using EgitimPortal.Application.Interfaces.Repositories;
using EgitimPortal.Persistance.Repositories;
using EgitimPortal.Application.Interfaces.UnitOfWorks;
using EgitimPortal.Persistance.UnitOfWorks;
using EgitimPortal.Domain.Entities;

namespace EgitimPortal.Persistance
{
    public static class Registration
    {
        public static void AddPersistance(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt => opt.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IReadRepository<>),typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddIdentityCore<User>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredLength = 2;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireDigit = false;
                opt.SignIn.RequireConfirmedEmail = false;
            })
                .AddRoles<Role>()
                .AddEntityFrameworkStores<AppDbContext>();

        }
    }
}
