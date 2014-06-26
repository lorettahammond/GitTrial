using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LorettaGitTrial.Startup))]
namespace LorettaGitTrial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
