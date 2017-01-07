using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WhereYouAt.Startup))]
namespace WhereYouAt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
