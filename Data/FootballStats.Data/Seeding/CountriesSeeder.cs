using FootballStats.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballStats.Data.Seeding
{
    public class CountriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Countries.Any())
            {
                return;
            }

            dbContext.Countries.Add(new Country { Name = "England", Abbreviation = "ENG" });
            dbContext.Countries.Add(new Country { Name = "Spain", Abbreviation = "ESP" });
            dbContext.Countries.Add(new Country { Name = "Italy", Abbreviation = "ITA" });
            dbContext.Countries.Add(new Country { Name = "Germany", Abbreviation = "GER" });
            dbContext.Countries.Add(new Country { Name = "France", Abbreviation = "FRA" });

        }
    }
}
