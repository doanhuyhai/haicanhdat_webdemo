using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(demo_webapp.Startup))]
namespace demo_webapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
