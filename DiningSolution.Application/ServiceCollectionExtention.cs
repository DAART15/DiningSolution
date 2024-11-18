using DiningSolution.Application.Abstractions.Mesaging;
using DiningSolution.Application.Personnels.Commands.CreatePersonel;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DiningSolution.Application
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddMediatR(config => config.RegisterServicesFromAssembly(assembly));

            services.AddTransient<ICommandHandler<CreatePersonnelCommand, int>, CreatePersonnelCommandHandler>();

            
            return services;
        }
    }
}
