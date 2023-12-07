using Microsoft.EntityFrameworkCore;
using WorldLeague.Domain.Entities;

namespace WorldLeague.Application.Context;

public interface IWorldLeagueDbContext
{
    DbSet<DrawResult> DrawResults{ get; set; }
}