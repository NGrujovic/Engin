using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnginUi.Startup))]
namespace EnginUi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
