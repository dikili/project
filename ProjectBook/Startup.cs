using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectBook.Startup))]
namespace ProjectBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
