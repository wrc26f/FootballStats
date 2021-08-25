namespace FootballStats.Services.Data
{
    using System.Threading.Tasks;

    using FootballStats.Data.Common.Repositories;
    using FootballStats.Data.Models;
    using FootballStats.Web.ViewModels.Matches;

    public class CreateMatchService : ICreateMatchService
    {
        private readonly IDeletableEntityRepository<Match> matchesRepository;

        public CreateMatchService(IDeletableEntityRepository<Match> matchesRepository)
        {
            this.matchesRepository = matchesRepository;
        }

        public async Task CreateAsync(CreateMatchInputModel input)
        {
            var match = new Match
            {
                HomeTeamId = input.HomeTeamId,
                HomeGoals = input.HomeGoals,
                AwayTeamId = input.AwayTeamId,
                AwayGoals = input.AwayGoals,
                DateMatch = input.DateMatch,
            };

            await this.matchesRepository.AddAsync(match);
            await this.matchesRepository.SaveChangesAsync();
        }
    }
}
