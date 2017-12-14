using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_403_Project_2.Startup))]
namespace _403_Project_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
