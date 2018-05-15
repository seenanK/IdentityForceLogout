using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityForceLogout.Startup))]
namespace IdentityForceLogout
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
