using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(firma.Startup))]
namespace firma
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
