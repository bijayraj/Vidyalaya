using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidyalaya.Startup))]
namespace Vidyalaya
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
