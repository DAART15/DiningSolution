using Microsoft.OpenApi.Models;

namespace DiningSolution.WEB.API.StartupConfiguration
{
    internal static class SwaggerConfiguration
    {
        public const string NameApiSwagger = "DiningSolution";
        public const string EndpointSwaggerJson = "/swagger/v1/swagger.json";
        public const string VersionApiSwagger = "v1";
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc(VersionApiSwagger, new OpenApiInfo { Title = NameApiSwagger, Version = VersionApiSwagger });
                });
            // =>>>>>>>>> viso i apacia vietoje virsaus reikes kai pradesiu su JWT daryti

            /*services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(VersionApiSwagger, new OpenApiInfo { Title = NameApiSwagger, Version = VersionApiSwagger });


                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] {}
                }
                });
            });*/
        }
    }
}
