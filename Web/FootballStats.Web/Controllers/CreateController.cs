using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballStats.Web.Controllers
{
    public class CreateController : Controller
    {
        public IActionResult OptionList()
        {
            return this.View();
        }
        // public IActionResult OptionList()
    }
}
