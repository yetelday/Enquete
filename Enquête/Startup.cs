using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Enquête.Startup))]
namespace Enquête
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
