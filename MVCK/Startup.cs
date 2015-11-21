using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCK.Startup))]
namespace MVCK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
