using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(小仙女5.Startup))]
namespace 小仙女5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
