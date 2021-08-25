namespace FootballStats.Services.Data
{
    using System.Threading.Tasks;

    using FootballStats.Web.ViewModels.Stadiums;

    public interface ICreateStadiumService
    {
        Task CreateAsync(CreateStadiumInputModel input);
    }
}
