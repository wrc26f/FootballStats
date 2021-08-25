using FootballStats.Data.Common.Repositories;
using FootballStats.Data.Models;
using FootballStats.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballStats.Services.Data
{
    public class FootballerService : IFootballerService
    {
        private readonly IDeletableEntityRepository<Footballer> footballersRepository;

        public FootballerService(IDeletableEntityRepository<Footballer> footballersRepository)
        {
            this.footballersRepository = footballersRepository;
        }

        public IEnumerable<T> GetAllFootballers<T>()
        {
            return this.footballersRepository.AllAsNoTracking()
                .To<T>()
                .ToList();
        }

        public T GetFootballersById<T>(int id)
        {
            return this.footballersRepository.AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefault();
        }
    }
}
