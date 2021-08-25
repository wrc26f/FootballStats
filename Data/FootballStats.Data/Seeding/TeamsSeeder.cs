using FootballStats.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballStats.Data.Seeding
{
    public class TeamsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Leagues.Any())
            {
                return;
            }

            _ = await dbContext.Teams.AddAsync(new Team { Name = "Manchester United" });
            await dbContext.SaveChangesAsync();

        }
    }
}
