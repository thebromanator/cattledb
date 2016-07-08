using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CattleApp.Startup))]
namespace CattleApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
