using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Easy_Banking.Startup))]
namespace Easy_Banking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
