using FootballStats.Data.Common.Repositories;
using FootballStats.Data.Models;
using FootballStats.Web.ViewModels.Stadiums;
using System.Threading.Tasks;

namespace FootballStats.Services.Data
{
    public class CreateStadiumService : ICreateStadiumService
    {
        private readonly IDeletableEntityRepository<Stadium> stadiumsRepository;

        public CreateStadiumService(IDeletableEntityRepository<Stadium> stadiumsRepository)
        {
            this.stadiumsRepository = stadiumsRepository;
        }

        public async Task CreateAsync(CreateStadiumInputModel input)
        {
            var stadium = new Stadium
            {
                Name = input.Name,
                Capacity = input.Capacity,
                UrlImage = input.UrlImage,
                CountryId = input.CountryId,
            };

            await this.stadiumsRepository.AddAsync(stadium);
            await this.stadiumsRepository.SaveChangesAsync();
        }
    }
}
