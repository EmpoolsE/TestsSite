using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestsSite.Startup))]
namespace TestsSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
