using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Phuket.Startup))]
namespace Phuket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
