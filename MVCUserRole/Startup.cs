using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCUserRole.Startup))]
namespace MVCUserRole
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
