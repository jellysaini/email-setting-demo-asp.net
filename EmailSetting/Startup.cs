using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmailSetting.Startup))]
namespace EmailSetting
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
