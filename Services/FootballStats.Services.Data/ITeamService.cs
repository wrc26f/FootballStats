using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStats.Services.Data
{
    public interface ITeamService
    {
        IEnumerable<KeyValuePair<int, string>> GetAllTeamsAsKeyValuePair();

        IEnumerable<T> GetAllTeams<T>();

        T GetTeamById<T>(int id);
    }
}
