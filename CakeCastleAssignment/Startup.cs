using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CakeCastleAssignment.Startup))]
namespace CakeCastleAssignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
