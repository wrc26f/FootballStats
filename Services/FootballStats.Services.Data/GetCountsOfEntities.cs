namespace FootballStats.Services.Data
{
    using System.Linq;

    using FootballStats.Data.Common.Repositories;
    using FootballStats.Data.Models;
    using FootballStats.Web.ViewModels.Home;

    public class GetCountsOfEntities : IGetCountsOfEntities
    {
        private readonly IDeletableEntityRepository<Footballer> footballersRepository;
        private readonly IDeletableEntityRepository<Team> teamsRepository;
        private readonly IDeletableEntityRepository<Match> matchesRepository;
        private readonly IDeletableEntityRepository<Stadium> stadiumsRepository;
        private readonly IDeletableEntityRepository<League> leaguesRepository;
        private readonly IDeletableEntityRepository<Country> countriesRepository;

        public GetCountsOfEntities(
            IDeletableEntityRepository<Footballer> footballersRepository,
            IDeletableEntityRepository<Team> teamsRepository,
            IDeletableEntityRepository<Match> matchesRepository,
            IDeletableEntityRepository<Stadium> stadiumsRepository,
            IDeletableEntityRepository<League> leaguesRepository,
            IDeletableEntityRepository<Country> countriesRepository)
        {
            this.footballersRepository = footballersRepository;
            this.teamsRepository = teamsRepository;
            this.matchesRepository = matchesRepository;
            this.stadiumsRepository = stadiumsRepository;
            this.leaguesRepository = leaguesRepository;
            this.countriesRepository = countriesRepository;
        }

        public IndexViewModel GetAllCount()
        {
            var indexViewModel = new IndexViewModel
            {
                CountriesCount = this.countriesRepository.AllAsNoTracking().Count(),
                LeaguesCount = this.leaguesRepository.AllAsNoTracking().Count(),
                TeamsCount = this.teamsRepository.AllAsNoTracking().Count(),
                FootballersCount = this.footballersRepository.AllAsNoTracking().Count(),
                StadiumssCount = this.stadiumsRepository.AllAsNoTracking().Count(),
                MatchesCount = this.matchesRepository.AllAsNoTracking().Count(),
            };
            return indexViewModel;
        }
    }
}
