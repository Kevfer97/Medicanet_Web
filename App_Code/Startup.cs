using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedicanetWeb.Startup))]
namespace MedicanetWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
