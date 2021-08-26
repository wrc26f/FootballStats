using FootballStats.Data.Common.Repositories;
using FootballStats.Data.Models;
using FootballStats.Services.Data;
using FootballStats.Web.ViewModels.Matches;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballStats.Web.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ChosenMatchController : BaseController
    {
        private readonly IMatchService matchService;

        public ChosenMatchController(IMatchService matchService)
        {
            this.matchService = matchService;
        }

        public async Task<ActionResult<MatchViewModel>> GetMatch(int matchId)
        {
             return this.matchService.GetAllMatches<MatchViewModel>().FirstOrDefault(x => x.Id == matchId);
        }
    }
}
