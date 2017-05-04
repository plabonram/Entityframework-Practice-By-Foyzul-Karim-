using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityframeworkPracticeByFoyzulKarim.Startup))]
namespace EntityframeworkPracticeByFoyzulKarim
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
