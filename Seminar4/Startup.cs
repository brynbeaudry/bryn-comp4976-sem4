using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Seminar4.Startup))]
namespace Seminar4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
