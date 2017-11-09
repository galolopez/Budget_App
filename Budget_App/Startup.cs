using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Budget_App.Startup))]
namespace Budget_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
