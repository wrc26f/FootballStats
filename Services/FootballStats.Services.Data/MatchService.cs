namespace FootballStats.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FootballStats.Data.Common.Repositories;
    using FootballStats.Data.Models;
    using FootballStats.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class MatchService : IMatchService
    {
        private readonly IDeletableEntityRepository<Match> matchesRepository;

        public MatchService(IDeletableEntityRepository<Match> matchesRepository)
        {
            this.matchesRepository = matchesRepository;
        }

        public IEnumerable<T> Get12Matches<T>(int page)
        {
            int itemsPerPage = 12;
            return this.matchesRepository.AllAsNoTracking()
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .To<T>()
                .ToList();
        }

        public IEnumerable<T> GetAllMatches<T>()
        {
            return this.matchesRepository.AllAsNoTracking()
                .To<T>()
                .ToList();
        }

        public IEnumerable<KeyValuePair<int, string>> GetAllDailyMatchesAsKeyValuePair()
        {
            return this.matchesRepository.AllAsNoTracking().Select(x => new
            {
                x.Id,
                Name = x.HomeTeam.Name + " - " + x.AwayTeam.Name,
            }).OrderBy(x => x.Name)
              .ToList().Select(x => new KeyValuePair<int, string>(x.Id, x.Name));
        }

        public T GetMatchById<T>(int id)
        {
            return this.matchesRepository.AllAsNoTracking()
                .Include(x => x.HomeTeam.Stadium)
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefault();
        }

    }
}
