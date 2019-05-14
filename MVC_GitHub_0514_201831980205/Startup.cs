using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_GitHub_0514_201831980205.Startup))]
namespace MVC_GitHub_0514_201831980205
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
