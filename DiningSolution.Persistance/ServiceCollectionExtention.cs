using DiningSolution.Domain.Repositories;
using DiningSolution.Persistance.Repositories;
using DiningSolution.Persistance.TemporaryData;
using Microsoft.Extensions.DependencyInjection;

namespace DiningSolution.Persistance
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services)
        {
            //services.AddScoped<IPersonnelRepository, PersonnelRepository>();
            services.AddScoped<IPersonnelRepository, PersonnelTemporaryData>();

            return services;
        }
    }
}
