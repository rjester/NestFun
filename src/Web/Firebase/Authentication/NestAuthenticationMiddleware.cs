using Microsoft.Owin;
using Microsoft.Owin.Security.Infrastructure;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataProtection;
using Microsoft.Owin.Security.DataHandler;

namespace NestFun.Firebase.Authentication
{
    public class NestAuthenticationMiddleware : AuthenticationMiddleware<NestAuthenticationOptions>
    {
        public NestAuthenticationMiddleware(OwinMiddleware next, IAppBuilder app, NestAuthenticationOptions options) : base(next, options)
        {
            //if (string.IsNullOrEmpty(Options.SignInAsAuthenticationType))
            //{
            //    options.SignInAsAuthenticationType = app.GetDefaultSignInAsAuthenticationType();
            //}
            if (options.StateDataFormat == null)
            {
                var dataProtector = app.CreateDataProtector(typeof(NestAuthenticationMiddleware).FullName,
                    options.AuthenticationType);

                options.StateDataFormat = new PropertiesDataFormat(dataProtector);
            }
        }
        
        protected override AuthenticationHandler<NestAuthenticationOptions> CreateHandler()
        {
            return new NestAuthenticationHandler();
        }
    }
}