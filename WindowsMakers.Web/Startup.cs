using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WindowsMakers.Web.Startup))]
namespace WindowsMakers.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
