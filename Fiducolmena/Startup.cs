using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fiducolmena.Startup))]
namespace Fiducolmena
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
