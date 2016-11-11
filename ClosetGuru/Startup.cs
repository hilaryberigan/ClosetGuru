using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClosetGuru.Startup))]
namespace ClosetGuru
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
