using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eBazzar.web.Startup))]
namespace eBazzar.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
