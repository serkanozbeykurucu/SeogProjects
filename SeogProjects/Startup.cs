using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeogProjects.Startup))]
namespace SeogProjects
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
