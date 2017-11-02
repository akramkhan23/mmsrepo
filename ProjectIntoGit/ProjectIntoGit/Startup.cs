using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectIntoGit.Startup))]
namespace ProjectIntoGit
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
