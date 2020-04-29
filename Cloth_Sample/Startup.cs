using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cloth_Sample.Startup))]
namespace Cloth_Sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
