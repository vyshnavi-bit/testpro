using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(samplegit.Startup))]
namespace samplegit
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
