using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EWallet.Startup))]
namespace EWallet
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
