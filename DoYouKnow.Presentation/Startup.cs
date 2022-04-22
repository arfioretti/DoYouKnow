using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoYouKnow.Presentation.Startup))]
namespace DoYouKnow.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
