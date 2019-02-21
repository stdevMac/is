using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IS_WebApplication.Startup))]
namespace IS_WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
