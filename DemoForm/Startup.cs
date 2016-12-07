using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoForm.Startup))]
namespace DemoForm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
