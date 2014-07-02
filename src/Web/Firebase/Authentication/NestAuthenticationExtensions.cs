using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestFun.Firebase.Authentication
{
    public static class NestAuthenticationExtensions
    {
        public static IAppBuilder UseNestAuthentication(this IAppBuilder app, NestAuthenticationOptions options)
        {
            return app.Use(typeof(NestAuthenticationMiddleware), app, options);
        }
    }
}