//using WorldLeague.Domain.Entities;
//using WorldLeague.Infrastructure.Context;

//namespace WorldLeague.Infrastructure
//{
//    public class DataSeeder
//    {
//        public static void SeedData(WorldLeagueDbContext dbContext)
//        {
//            if (!dbContext.CountryGroups.Any())
//            {
//                var countryGroups = new List<CountryGroup>
//                {
//                    new CountryGroup{Name = "Türkiye",
//                        Teams = new List<Team>{
//                            new Team{Id = 1,Name = "Adesso İstanbul" },
//                            new Team{Id = 1,Name = "Adesso Ankara" },
//                            new Team{Id = 1,Name = "Adesso İzmir" },
//                            new Team{Id = 1,Name = "Adesso Antalya" }
//                        }
//                    },
//                    new CountryGroup{Name = "Almanya",
//                        Teams = new List<Team>{
//                            new Team{Id = 1,Name = "Adesso Berlin" },
//                            new Team{Id = 1,Name = "Adesso Frankfurt" },
//                            new Team{Id = 1,Name = "Adesso Münih" },
//                            new Team{Id = 1,Name = "Adesso Dortmund" }
//                        }
//                    },
//                    new CountryGroup{Name = "Fransa",
//                        Teams = new List<Team>{
//                            new Team{Id = 1,Name = "Adesso Paris" },
//                            new Team{Id = 1,Name = "Adesso Marsilya" },
//                            new Team{Id = 1,Name = "Adesso Nice" },
//                            new Team{Id = 1,Name = "Adesso Lyon" }
//                        }
//                    },
//                    new CountryGroup{Name = "Hollanda",
//                        Teams = new List<Team>{
//                            new Team{Id = 1,Name = "Adesso Amsterdam" },
//                            new Team{Id = 1,Name = "Adesso Rotterdam" },
//                            new Team{Id = 1,Name = "Adesso Lahey" },
//                            new Team{Id = 1,Name = "Adesso Eindhoven" }
//                        }
//                    },
//                    new CountryGroup{Name = "Portekiz",
//                        Teams = new List<Team>{
//                            new Team{Id = 1,Name = "Adesso Lisbon" },
//                            new Team{Id = 1,Name = "Adesso Porto" },
//                            new Team{Id = 1,Name = "Adesso Braga" },
//                            new Team{Id = 1,Name = "Adesso Coimbra" }
//                        }
//                    },
//                    new CountryGroup{Name = "İtalya",
//                        Teams = new List<Team>{
//                            new Team{Id = 1,Name = "Adesso Roma" },
//                            new Team{Id = 1,Name = "Adesso Milano" },
//                            new Team{Id = 1,Name = "Adesso Venedik" },
//                            new Team{Id = 1,Name = "Adesso Napoli" }
//                        }
//                    },
//                    new CountryGroup{Name = "İspanya",
//                        Teams = new List<Team>{
//                            new Team{Id = 1,Name = "Adesso Sevilla" },
//                            new Team{Id = 1,Name = "Adesso Madrid" },
//                            new Team{Id = 1,Name = "Adesso Bersolona" },
//                            new Team{Id = 1,Name = "Adesso Granada" }
//                        }
//                    },
//                    new CountryGroup{Name = "Belçika",
//                        Teams = new List<Team>{
//                            new Team{Id = 1,Name = "Adesso Brüksel" },
//                            new Team{Id = 1,Name = "Adesso Brugge" },
//                            new Team{Id = 1,Name = "Adesso Gent" },
//                            new Team{Id = 1,Name = "Adesso Anvers" }
//                        }
//                    }
//                };

//                dbContext.CountryGroups.AddRange(countryGroups);
//                dbContext.SaveChanges();
//            }
//        }
//    }
//}
