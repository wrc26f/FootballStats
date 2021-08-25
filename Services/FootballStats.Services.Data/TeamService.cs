namespace FootballStats.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using FootballStats.Data.Common.Repositories;
    using FootballStats.Data.Models;
    using FootballStats.Services.Mapping;

    public class TeamService : ITeamService
    {
        private readonly IDeletableEntityRepository<Team> teamsRepository;

        public TeamService(IDeletableEntityRepository<Team> teamsRepository)
        {
            this.teamsRepository = teamsRepository;
        }

        public IEnumerable<KeyValuePair<int, string>> GetAllTeamsAsKeyValuePair()
        {
            return this.teamsRepository.AllAsNoTracking().Select(x => new
            {
                x.Id,
                x.Name,
            }).ToList()
              .Select(x => new KeyValuePair<int, string>(x.Id, x.Name));
        }

        public IEnumerable<T> GetAllTeams<T>()
        {
            return this.teamsRepository.AllAsNoTracking()
                .To<T>()
                .ToList();
        }

        public T GetTeamById<T>(int id)
        {
            return this.teamsRepository.AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefault();
        }
    }
}
