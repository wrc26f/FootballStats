using FootballStats.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStats.Services.Data
{
    public class GetAllEnums : IGetAllEnums
    {
        public IEnumerable<KeyValuePair<string, int>> GetAllEnumsAsKeyValuePair()
        {
            var list = new List<KeyValuePair<string, int>>();
            string[] names = Enum.GetNames(typeof(Position));
            Position[] values = (Position[])Enum.GetValues(typeof(Position));

            for (int i = 0; i < names.Length; i++)
            {
                var pair = new KeyValuePair<string, int>(names[i], (int)values[i]);
                list.Add(pair);
            }

            return list;
        }
    }
}
