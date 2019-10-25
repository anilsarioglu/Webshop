using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webshop.UI_MVC.Startup))]
namespace Webshop.UI_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
