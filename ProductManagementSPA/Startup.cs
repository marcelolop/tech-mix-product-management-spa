// Ignore Spelling: app

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductManagementSPA.Startup))]
namespace ProductManagementSPA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
