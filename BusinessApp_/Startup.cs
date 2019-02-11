using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BusinessApp_.Startup))]
namespace BusinessApp_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
