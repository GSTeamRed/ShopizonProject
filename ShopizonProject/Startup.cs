using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopizonProject.Startup))]
namespace ShopizonProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
