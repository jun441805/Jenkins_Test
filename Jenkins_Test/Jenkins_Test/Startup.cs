using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jenkins_Test.Startup))]
namespace Jenkins_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
