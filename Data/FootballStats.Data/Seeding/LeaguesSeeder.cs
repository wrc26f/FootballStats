using FootballStats.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballStats.Data.Seeding
{
    public class LeaguesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Leagues.Any())
            {
                return;
            }

            await dbContext.Leagues.AddAsync(new League { Name = "Premier League", Country = dbContext.Countries.First(x => x.Abbreviation == "ENG") });
            await dbContext.Leagues.AddAsync(new League { Name = "Championship", Country = dbContext.Countries.First(x => x.Abbreviation == "ENG") });
            await dbContext.Leagues.AddAsync(new League { Name = "La Liga", Country = dbContext.Countries.First(x => x.Abbreviation == "ESP") });
            await dbContext.Leagues.AddAsync(new League { Name = "Serie A", Country = dbContext.Countries.First(x => x.Abbreviation == "ITA") });
            await dbContext.Leagues.AddAsync(new League { Name = "Bundesliga", Country = dbContext.Countries.First(x => x.Abbreviation == "GER") });
            await dbContext.Leagues.AddAsync(new League { Name = "Ligue 1", Country = dbContext.Countries.First(x => x.Abbreviation == "FRA") });
            await dbContext.SaveChangesAsync();

        }
    }
}
