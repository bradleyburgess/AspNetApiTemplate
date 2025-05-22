
using AspNetApiTemplate.Data;
using AspNetApiTemplate.Repositories;
using AspNetApiTemplate.Security;
using AspNetApiTemplate.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Scalar.AspNetCore;

namespace AspNetApiTemplate.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAppRepositoriesAndServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
        );



        services.AddScoped<IUsersRepository, UsersRepository>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<ITokenHasher, TokenHasher>();

        services.AddControllers();
        services.AddOpenApi();

        return services;
    }
}
