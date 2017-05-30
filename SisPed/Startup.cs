using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SisPed.Startup))]
namespace SisPed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
