using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaiThucHanh3.Startup))]
namespace BaiThucHanh3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
