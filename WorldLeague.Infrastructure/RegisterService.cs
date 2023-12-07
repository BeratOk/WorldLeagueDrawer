using WorldLeague.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WorldLeague.Application.Context;

namespace WorldLeague.Infrastructure;

public static class RegisterService
{
    public static void ConfigureInfraStructure(this IServiceCollection services,
    IConfiguration configuration)
    {
        services.AddDbContext<WorldLeagueDbContext>(options =>
        {
            options.UseSqlServer("Server=web04.limonhost.net;Database=beratcommerce;User=beratcommerceuser;Password=0M_x5z7u9; TrustServerCertificate=True;");
        });

        services.AddScoped<IWorldLeagueDbContext>(option => {
           return option.GetService<WorldLeagueDbContext>()!;
        });
    }
}