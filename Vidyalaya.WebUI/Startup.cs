using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidyalaya.WebUI.Startup))]
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "Web.config", Watch = true)]

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
