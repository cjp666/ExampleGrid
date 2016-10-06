using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExampleGrid.Startup))]
namespace ExampleGrid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
