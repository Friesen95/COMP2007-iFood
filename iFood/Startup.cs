using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iFood.Startup))]
namespace iFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
