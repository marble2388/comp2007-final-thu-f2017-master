using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalB.Startup))]
namespace FinalB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
