using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NestFun.Firebase.Startup))]
namespace NestFun.Firebase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
