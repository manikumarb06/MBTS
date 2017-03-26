using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MBTS.Startup))]
namespace MBTS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
