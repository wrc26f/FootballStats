using System.Collections.Generic;

namespace FootballStats.Services.Data
{
    public interface IGetAllEnums
    {
        IEnumerable<KeyValuePair<string, int>> GetAllEnumsAsKeyValuePair();
    }
}
