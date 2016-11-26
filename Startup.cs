using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(districtProject.Startup))]
namespace districtProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
