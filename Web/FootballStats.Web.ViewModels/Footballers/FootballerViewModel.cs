using AutoMapper;
using FootballStats.Data.Models;
using FootballStats.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStats.Web.ViewModels.Footballers
{
    public class FootballerViewModel : IMapFrom<Footballer>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Position Position { get; set; }

        public Team Team { get; set; }

        public Country Country { get; set; }

        public DateTime CreatedOn { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {

        }
    }
}
