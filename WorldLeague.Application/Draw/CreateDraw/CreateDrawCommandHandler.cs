using AutoMapper;
using WorldLeague.Application.Context;
using MediatR;
using WorldLeague.Domain.Entities;

namespace WorldLeague.Application.Draw.CreateDraw;

public class CreateDrawRequestHandler : IRequestHandler<CreateDrawRequest, DrawResult>
{
    private readonly IWorldLeagueDbContext _dbContext;
    public CreateDrawRequestHandler(IWorldLeagueDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<DrawResult> Handle(CreateDrawRequest request, CancellationToken cancellationToken)
    {
        List<CountryGroup> countryGroups = new List<CountryGroup>
        {
            new CountryGroup{Name = "Türkiye",
                Teams = new List<Team>{
                    new Team{Name = "Adesso Ýstanbul" },
                    new Team{Name = "Adesso Ankara" },
                    new Team{Name = "Adesso Ýzmir" },
                    new Team{Name = "Adesso Antalya" }
                }
            },
            new CountryGroup{Name = "Almanya",
                Teams = new List<Team>{
                    new Team{Name = "Adesso Berlin" },
                    new Team{Name = "Adesso Frankfurt" },
                    new Team{Name = "Adesso Münih" },
                    new Team{Name = "Adesso Dortmund" }
                }
            },
            new CountryGroup{Name = "Fransa",
                Teams = new List<Team>{
                    new Team{Name = "Adesso Paris" },
                    new Team{Name = "Adesso Marsilya" },
                    new Team{Name = "Adesso Nice" },
                    new Team{Name = "Adesso Lyon" }
                }
            },
            new CountryGroup{Name = "Hollanda",
                Teams = new List<Team>{
                    new Team{Name = "Adesso Amsterdam" },
                    new Team{Name = "Adesso Rotterdam" },
                    new Team{Name = "Adesso Lahey" },
                    new Team{Name = "Adesso Eindhoven" }
                }
            },
            new CountryGroup{Name = "Portekiz",
                Teams = new List<Team>{
                    new Team{Name = "Adesso Lisbon" },
                    new Team{Name = "Adesso Porto" },
                    new Team{Name = "Adesso Braga" },
                    new Team{Name = "Adesso Coimbra" }
                }
            },
            new CountryGroup{Name = "Ýtalya",
                Teams = new List<Team>{
                    new Team{Name = "Adesso Roma" },
                    new Team{Name = "Adesso Milano" },
                    new Team{Name = "Adesso Venedik" },
                    new Team{Name = "Adesso Napoli" }
                }
            },
            new CountryGroup{Name = "Ýspanya",
                Teams = new List<Team>{
                    new Team{Name = "Adesso Sevilla" },
                    new Team{Name = "Adesso Madrid" },
                    new Team{Name = "Adesso Bersolona" },
                    new Team{Name = "Adesso Granada" }
                }
            },
            new CountryGroup{Name = "Belçika",
                Teams = new List<Team>{
                    new Team{Name = "Adesso Brüksel" },
                    new Team{Name = "Adesso Brugge" },
                    new Team{Name = "Adesso Gent" },
                    new Team{Name = "Adesso Anvers" }
                }
            }
        };

        DrawResult result = new DrawResult
        {
            DrawerName = request.DrawerName,
            DrawerSurname = request.DrawerSurname,
            Groups = new List<DrawGroup> { }
        };

        Random rnd = new Random();


        for (int k = 0; k < 32 / request.GroupCount; k++)
        {
            for (int i = 0; i < request.GroupCount; i++)
            {
                if (k == 0)
                {
                    var randomCountry = countryGroups[rnd.Next(0, countryGroups.Count)];
                    var randomTeam = randomCountry.Teams[rnd.Next(0, randomCountry.Teams.Count)];
                    result.Groups.Add(new DrawGroup()
                    {
                        Name = ((char)(65 + i)).ToString(),
                        Teams = new List<Team>()
                    {
                            randomTeam
                    }
                    });
                }

                else
                {
                    var selectableTeams = countryGroups.Where(q => q.Teams.Intersect(result.Groups[i].Teams).Count() == 0).SelectMany(q => q.Teams.Where(k => !result.Groups.SelectMany(c => c.Teams).Contains(k))).ToList();
                    var randomTeam = selectableTeams[rnd.Next(0, selectableTeams.Count)];
                    result.Groups[i].Teams.Add(randomTeam);
                }
            }
        }

        await _dbContext.DrawResults.AddRangeAsync(result);
        await _dbContext.SaveToDbAsync();

        return result;
    }
}