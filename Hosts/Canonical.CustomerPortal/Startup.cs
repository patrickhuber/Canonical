using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Canonical.CustomerPortal.Startup))]
namespace Canonical.CustomerPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
