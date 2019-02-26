using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalR.App_Start.Startup))]
namespace SignalR.App_Start
{
    public class Startup
    {
        public static void ConfigureSignalR(IAppBuilder app)
        {
            app.MapSignalR();
        }

        public static void Configuration(IAppBuilder app)
        {
            Startup.ConfigureSignalR(app);
        }
    }
}