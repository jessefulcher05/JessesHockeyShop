using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JessesHockeyShop.Startup))]
namespace JessesHockeyShop
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
