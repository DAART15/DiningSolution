using DiningSolution.WEB.API.StartupConfiguration;

namespace DiningSolution.WEB.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var startup = new Startup(builder.Configuration);
            startup.ConfigureServices(builder.Services);
            var app = builder.Build();
            startup.ConfigureCorsEnvironment(app, app.Environment);
            app.MapControllers();
            app.Run();
        }
    }
}
