using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeFinder.WebApi.Hosting
{
    public static class HostingEnvironmentExtensions
    {
        public static bool IsLocal(this IWebHostEnvironment webHostingEnvironment)
        {
            if(webHostingEnvironment == null)
            {
                throw new ArgumentNullException(nameof(webHostingEnvironment));
            }
            return webHostingEnvironment.IsEnvironment(EnvironmentName.Local);
        }

        public static bool IsDevelopment(this IWebHostEnvironment webHostingEnvironment)
        {
            if (webHostingEnvironment == null)
            {
                throw new ArgumentNullException(nameof(webHostingEnvironment));
            }
            return webHostingEnvironment.IsEnvironment(EnvironmentName.Development);
        }

        public static bool IsProduction(this IWebHostEnvironment webHostingEnvironment)
        {
            if (webHostingEnvironment == null)
            {
                throw new ArgumentNullException(nameof(webHostingEnvironment));
            }
            return webHostingEnvironment.IsEnvironment(EnvironmentName.Production);
        }

        public static bool IsTest(this IWebHostEnvironment webHostingEnvironment)
        {
            if (webHostingEnvironment == null)
            {
                throw new ArgumentNullException(nameof(webHostingEnvironment));
            }
            return webHostingEnvironment.IsEnvironment(EnvironmentName.Test);
        }

        public static bool IsUAT(this IWebHostEnvironment webHostingEnvironment)
        {
            if (webHostingEnvironment == null)
            {
                throw new ArgumentNullException(nameof(webHostingEnvironment));
            }
            return webHostingEnvironment.IsEnvironment(EnvironmentName.UAT);
        }
    }
}
