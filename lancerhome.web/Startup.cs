using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lancerhome.web.Startup))]
namespace lancerhome.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
