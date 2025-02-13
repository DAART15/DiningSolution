using DiningSolution.Application;
using DiningSolution.Persistance;

namespace DiningSolution.WEB.API.StartupConfiguration
{
    public class Startup(IConfiguration configuration)
    {
        public IConfiguration Configuration { get; } = configuration;
        public string ConnectionString
        {
            get
            {
                string diningSolutionDBString = Configuration.GetConnectionString("DefaultConnection");
                return diningSolutionDBString;
            }
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureCors();
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.ConfigureSwagger();
            services.ConfigureJWT(Configuration);
            services.AddPersistance();
            services.AddApplication();
        }
        public void ConfigureCorsEnvironment(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseCors(SecurityConfiguration.DevelopmentCorsPolicy);
            }
            else
            {
                app.UseCors(SecurityConfiguration.ProductionCorsPolicy);
            }
            app.UseAuthentication();
            app.UseAuthorization();
        }
    }
}
