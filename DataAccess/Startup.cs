using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataAccess.Startup))]
namespace DataAccess
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
