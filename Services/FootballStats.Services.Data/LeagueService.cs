namespace FootballStats.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FootballStats.Data.Common.Repositories;
    using FootballStats.Data.Models;
    using FootballStats.Services.Mapping;
    using FootballStats.Web.ViewModels.Home;
    using FootballStats.Web.ViewModels.Leagues;

    public class LeagueService : ILeagueService
    {
        private readonly IDeletableEntityRepository<League> leagueRepository;

        public LeagueService(IDeletableEntityRepository<League> leagueRepository)
        {
            this.leagueRepository = leagueRepository;
        }

        public IEnumerable<T> GetAllLeagues<T>()
        {
            return this.leagueRepository.AllAsNoTracking()
                .To<T>()
                .ToList();
        }

        public IEnumerable<KeyValuePair<int, string>> GetAllLeaguesAsKeyValuePairForCatalog()
        {
            var viewModel = this.leagueRepository.AllAsNoTracking()
                                        .Select(x => new
                                        {
                                            x.Id,
                                            x.Name,
                                        }).ToList()
                                        .Select(x => new KeyValuePair<int, string>(x.Id, x.Name))
                                        .ToList();
            viewModel.Insert(0, new KeyValuePair<int, string>(0, "All"));
            return viewModel;
        }

        public T GetLeagueById<T>(int id)
        {
            return this.leagueRepository.AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefault();
        }

        public IEnumerable<LeagueWithMatchesCountViewModel> GetLeagueDailyMatches()
        {
            return this.leagueRepository.AllAsNoTracking()
                .Select(x => new LeagueWithMatchesCountViewModel
                {
                    LeagueName = x.Name,
                    MatchesCount = x.Teams.SelectMany(x => x.HomeMatches).Where(x => x.DateMatch.Date == DateTime.Now.Date).Count(),
                }).ToList();
        }

        public IEnumerable<KeyValuePair<int, string>> GetAllLeaguesAsKeyValuePair()
        {
            return this.leagueRepository.AllAsNoTracking()
                                        .Select(x => new
                                        {
                                            x.Id,
                                            x.Name,
                                        }).ToList()
                                        .Select(x => new KeyValuePair<int, string>(x.Id, x.Name))
                                        .ToList();
        }
    }
}
