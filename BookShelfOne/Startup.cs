using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookShelfOne.Startup))]
namespace BookShelfOne
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
