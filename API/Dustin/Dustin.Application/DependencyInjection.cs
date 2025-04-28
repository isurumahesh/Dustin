using Dustin.Application.Validators;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Dustin.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
            });

            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.AddValidatorsFromAssemblyContaining<CreateProductValidator>();

            return services;
        }
    }
}