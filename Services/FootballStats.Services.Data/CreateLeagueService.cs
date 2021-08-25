namespace FootballStats.Services.Data
{
    using System.Threading.Tasks;

    using FootballStats.Data.Common.Repositories;
    using FootballStats.Data.Models;
    using FootballStats.Web.ViewModels.League;

    public class CreateLeagueService : ICreateLeagueService
    {
        private readonly IDeletableEntityRepository<League> leagueRepository;

        public CreateLeagueService(IDeletableEntityRepository<League> leagueRepository)
        {
            this.leagueRepository = leagueRepository;
        }

        public async Task CreateAsync(CreateLeagueInputModel input)
        {
            var league = new League
            {
                Name = input.Name,
                UrlImage=input.UrlImage,
                CountryId = input.CountryId,
            };

            await this.leagueRepository.AddAsync(league);
            await this.leagueRepository.SaveChangesAsync();
        }
    }
}
