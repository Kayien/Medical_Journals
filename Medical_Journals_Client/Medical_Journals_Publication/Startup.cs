using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Medical_Journals_Publication.Startup))]
namespace Medical_Journals_Publication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
