using System.Collections;
using System.Collections.Generic;

namespace FootballStats.Services.Data
{
    public interface IStadiumService
    {
        IEnumerable<KeyValuePair<int, string>> GetAllStadiumsAsKeyValuePair();

        IEnumerable<T> GetAllStadiums<T>();

        T GetStadiumById<T>(int id);
    }
}
