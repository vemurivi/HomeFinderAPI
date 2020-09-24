using HomeFinder.Data;
using HomeFinder.Data.Repository.Implementations;
using HomeFinder.Data.Repository.Interfaces;
using HomeFinder.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;

namespace HomeFinder.Services.Extensions
{
    public static class IOCExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<HouseDBContext>(x => x.UseSqlServer(@"Server=DESKTOP-FVL63VH\MSSQLSERVER01;Database=HouseDB;Trusted_Connection=True;"));
            services.AddScoped<IHouseDBContext>(y => y.GetService<HouseDBContext>());
            services.AddOptions();
            services.AddScoped<IBuyerRepo, BuyerRepo>();
            services.AddScoped<ISellerRepo, SellerRepo>();
            services.AddScoped<IHouseRepo, HouseRepo>();
            services.AddScoped<IHouseProspectRepo, HouseProspectRepo>();
            services.AddScoped<ICommentRepo, CommentRepo>();

            services.RegisterAssemblyScoped(typeof(IBuyerService));
            services.RegisterAssemblyScoped(typeof(ICommentService));
            services.RegisterAssemblyScoped(typeof(IHouseProspectService));
            services.RegisterAssemblyScoped(typeof(IHouseService));
            services.RegisterAssemblyScoped(typeof(ISellerService));

            services.AddScoped<System.Security.Principal.IPrincipal>(Sp => Sp.GetService<IHttpContextAccessor>()?.HttpContext?.User);
            return services;
        }
        

        private static IServiceCollection RegisterAssemblyScoped (this IServiceCollection services, Type interfaceType)
        {
            var assembly = Assembly.GetAssembly(interfaceType);
            
            foreach(var i in assembly.GetTypes().Where(t => t.IsInterface))
            {
                var t = assembly.GetTypes().FirstOrDefault(x => x.IsClass && i.IsAssignableFrom(x) && !x.IsAbstract);
                if(t != null)
                {
                    services.AddScoped(i,t);
                }
            }

            return services;
        }
    }
}
