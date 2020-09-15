using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(POne.Startup))]
namespace POne
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
