namespace FootballStats.Services.Data
{
    using System.Threading.Tasks;

    using FootballStats.Data.Common.Repositories;
    using FootballStats.Data.Models;
    using FootballStats.Web.ViewModels.Countries;

    public class CreateCountryService : ICreateCountryService
    {
        private readonly IDeletableEntityRepository<Country> countriesRepositories;

        public CreateCountryService(IDeletableEntityRepository<Country> countriesRepositories)
        {
            this.countriesRepositories = countriesRepositories;
        }

        public async Task CreateAsync(CreateCountryInputModel input)
        {
            var country = new Country
            {
                Name = input.Name,
                Abbreviation = input.Abbreviation.ToUpper(),
                UrlImage = input.UrlImage,
            };

            await this.countriesRepositories.AddAsync(country);
            await this.countriesRepositories.SaveChangesAsync();
        }
    }
}
