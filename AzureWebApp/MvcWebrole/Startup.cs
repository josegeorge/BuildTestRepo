using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcWebrole.Startup))]
namespace MvcWebrole
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
