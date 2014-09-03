using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Canonical.SupplierPortal.Startup))]
namespace Canonical.SupplierPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
