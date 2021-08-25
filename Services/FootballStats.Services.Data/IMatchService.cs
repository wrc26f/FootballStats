namespace FootballStats.Services.Data
{
    using System.Collections.Generic;

    public interface IMatchService
    {
        IEnumerable<T> GetAllMatches<T>();

        IEnumerable<T> Get12Matches<T>(int page);

        IEnumerable<KeyValuePair<int, string>> GetAllDailyMatchesAsKeyValuePair();

        T GetMatchById<T>(int id);
    }
}
