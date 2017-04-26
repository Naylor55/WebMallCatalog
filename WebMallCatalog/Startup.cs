using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMallCatalog.Startup))]
namespace WebMallCatalog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
