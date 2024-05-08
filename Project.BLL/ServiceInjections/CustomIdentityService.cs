using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ServiceInjections
{
    public static class CustomIdentityService
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, IdentityRole<int>>(x =>
            {
                x.Password.RequireDigit = true;
                x.Password.RequiredLength = 3;
                x.Password.RequireUppercase = true;
                x.Password.RequireLowercase = true;
                x.SignIn.RequireConfirmedEmail = true;
                x.Password.RequireNonAlphanumeric = true;

            }).AddEntityFrameworkStores<MyContext>();

            return services;
        }
    }
}
