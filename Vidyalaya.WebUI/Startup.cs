using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidyalaya.WebUI.Startup))]
namespace Vidyalaya.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
