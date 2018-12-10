using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BooksWebsite.Startup))]
namespace BooksWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
