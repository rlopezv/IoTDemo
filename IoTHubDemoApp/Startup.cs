using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(IoTHubDemoApp.Startup))]
namespace IoTHubDemoApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}