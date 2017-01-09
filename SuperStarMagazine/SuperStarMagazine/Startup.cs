using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperStarMagazine.Startup))]
namespace SuperStarMagazine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
