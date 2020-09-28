using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeFinder.WebApi.Hosting
{
    public static class EnvironmentName
    {
        public static readonly string Local = nameof(Local);

        public static readonly string Development = nameof(Development);

        public static readonly string Production = nameof(Production);

        public static readonly string Test = nameof(Test);

        public static readonly string UAT = nameof(UAT);

     }

}
