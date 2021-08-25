namespace FootballStats.Services.Data
{
    using System.Collections.Generic;

    using FootballStats.Data.Models;
    using FootballStats.Web.ViewModels.Home;
    using FootballStats.Web.ViewModels.Leagues;

    public interface ILeagueService
    {
        IEnumerable<T> GetAllLeagues<T>();

        IEnumerable<KeyValuePair<int, string>> GetAllLeaguesAsKeyValuePair();

        T GetLeagueById<T>(int id);

        IEnumerable<LeagueWithMatchesCountViewModel> GetLeagueDailyMatches();

        IEnumerable<KeyValuePair<int, string>> GetAllLeaguesAsKeyValuePairForCatalog();
    }
}
