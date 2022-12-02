using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_2nd_try.Startup))]
namespace Vidly_2nd_try
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
