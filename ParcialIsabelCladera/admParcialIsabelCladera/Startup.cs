using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admParcialIsabelCladera.Startup))]
namespace admParcialIsabelCladera
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
