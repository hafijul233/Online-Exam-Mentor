using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamManagementSystem.Startup))]
namespace ExamManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
