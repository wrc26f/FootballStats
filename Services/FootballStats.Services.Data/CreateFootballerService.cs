using FootballStats.Data.Common.Repositories;
using FootballStats.Data.Models;
using FootballStats.Services.Data;
using FootballStats.Web.ViewModels.Footballers;
using System.Threading.Tasks;

public class CreateFootballerService : ICreateFootballerService
{
    private readonly IDeletableEntityRepository<Footballer> footballersRepository;

    public CreateFootballerService(IDeletableEntityRepository<Footballer> footballersRepository)
    {
        this.footballersRepository = footballersRepository;
    }

    public async Task CreateAsync(CreateFootballerInputModel input)
    {
        var footballer = new Footballer
        {
            FirstName = input.FirstName,
            LastName = input.LastName,
            BirthDate = input.BirthDate,
            CountryId = input.CountryId,
            Position = input.Position,
            TeamId = input.TeamId,
        };

        await this.footballersRepository.AddAsync(footballer);
        await this.footballersRepository.SaveChangesAsync();
    }
}
