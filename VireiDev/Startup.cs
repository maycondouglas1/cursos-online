using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VireiDev.Startup))]
namespace VireiDev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
