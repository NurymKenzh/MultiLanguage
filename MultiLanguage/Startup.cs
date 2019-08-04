using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultiLanguage.Startup))]
namespace MultiLanguage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
