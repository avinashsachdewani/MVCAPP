using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMvcApp.Startup))]
namespace TestMvcApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
