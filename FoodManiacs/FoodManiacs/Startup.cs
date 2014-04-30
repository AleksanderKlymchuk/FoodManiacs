using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodManiacs.Startup))]
namespace FoodManiacs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
