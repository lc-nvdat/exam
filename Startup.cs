using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamASP.Startup))]
namespace ExamASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
