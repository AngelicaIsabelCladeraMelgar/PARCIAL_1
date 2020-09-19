using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admParcial1IsabelCladera.Startup))]
namespace admParcial1IsabelCladera
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
