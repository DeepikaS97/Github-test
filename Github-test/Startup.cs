using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Github_test.Startup))]
namespace Github_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
