using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CWR.Web.Startup))]
namespace CWR.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
