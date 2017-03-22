using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaMasterPage.Startup))]
namespace PruebaMasterPage
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
