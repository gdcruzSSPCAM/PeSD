using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PeSD.Startup))]
namespace PeSD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
