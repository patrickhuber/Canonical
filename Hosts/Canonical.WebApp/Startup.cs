using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Canonical.WebApp.Startup))]
namespace Canonical.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
