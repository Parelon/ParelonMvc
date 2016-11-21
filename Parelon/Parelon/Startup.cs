using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Parelon.Startup))]
namespace Parelon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
