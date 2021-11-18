using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeedManagementSystem_Balraj.Startup))]
namespace SeedManagementSystem_Balraj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
