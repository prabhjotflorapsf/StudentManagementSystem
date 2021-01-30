using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentM.Startup))]
namespace StudentM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
