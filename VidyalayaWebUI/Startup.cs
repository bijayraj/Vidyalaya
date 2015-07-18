using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidyalayaWebUI.Startup))]
namespace VidyalayaWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
