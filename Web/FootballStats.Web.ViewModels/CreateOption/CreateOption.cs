namespace FootballStats.Web.ViewModels.CreateOption
{
    using System.Collections.Generic;

    public class CreateOption
    {
        public string Route { get; set; }

        public IEnumerable<string> Options { get; set; }
    }
}
