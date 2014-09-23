using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BtcSolutions.Crm.Web.Startup))]
namespace BtcSolutions.Crm.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
