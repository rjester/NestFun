using Microsoft.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestFun.Firebase.Authentication
{
    public class NestAuthenticationOptions : AuthenticationOptions
    {
        public NestAuthenticationOptions() : base(Constants.DefaultAuthenticationType)
        {
            Description.Caption = Constants.DefaultAuthenticationType;
            CallbackPath = new PathString("/ExternalLoginCallback");
            AuthenticationMode = AuthenticationMode.Passive;
        }

        public PathString CallbackPath { get; set; }

        public string SignInAsAuthenticationType { get; set; }

        public ISecureDataFormat<AuthenticationProperties> StateDataFormat { get; set; }
    }
}