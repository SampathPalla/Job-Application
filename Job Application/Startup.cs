using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Job_Application.Startup))]
namespace Job_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
