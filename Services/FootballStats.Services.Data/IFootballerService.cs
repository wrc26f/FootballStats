using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStats.Services.Data
{
    public interface IFootballerService
    {
        IEnumerable<T> GetAllFootballers<T>();

        T GetFootballersById<T>(int id);
    }
}
