using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WorldLeague.Application.Context;
using WorldLeague.Domain.Entities;
using WorldLeague.Infrastructure.DataConfigs;

namespace WorldLeague.Infrastructure.Context;

public class WorldLeagueDbContext : DbContext, IWorldLeagueDbContext
{
    public WorldLeagueDbContext(DbContextOptions<WorldLeagueDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new DrawResultConfig());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    public DbSet<DrawResult> DrawResults { get; set; }
}