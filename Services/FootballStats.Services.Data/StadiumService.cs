namespace FootballStats.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using FootballStats.Data.Common.Repositories;
    using FootballStats.Data.Models;
    using FootballStats.Services.Mapping;

    public class StadiumService : IStadiumService
    {
        private readonly IDeletableEntityRepository<Stadium> stadiumsRepository;

        public StadiumService(IDeletableEntityRepository<Stadium> stadiumsRepository)
        {
            this.stadiumsRepository = stadiumsRepository;
        }

        public IEnumerable<T> GetAllStadiums<T>()
        {
            return this.stadiumsRepository.AllAsNoTracking()
                   .To<T>()
                   .ToList();
        }

        public IEnumerable<KeyValuePair<int, string>> GetAllStadiumsAsKeyValuePair()
        {
            return this.stadiumsRepository.AllAsNoTracking()
                                          .Select(x => new
                                          {
                                              x.Id,
                                              x.Name,
                                          }).ToList()
                                            .Select(x => new KeyValuePair<int, string>(x.Id, x.Name))
                                            .ToList();
        }

        public T GetStadiumById<T>(int id)
        {
            return this.stadiumsRepository.AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefault();
        }
    }
}
