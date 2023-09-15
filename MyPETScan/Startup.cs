using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyPETScan.Startup))]
namespace MyPETScan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
