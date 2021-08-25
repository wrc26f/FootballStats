namespace FootballStats.Services.Data
{
    using System.Threading.Tasks;

    using FootballStats.Web.ViewModels.Footballers;

    public interface ICreateFootballerService
    {
        Task CreateAsync(CreateFootballerInputModel input);
    }
}
