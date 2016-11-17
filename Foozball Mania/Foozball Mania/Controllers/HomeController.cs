using Foozball_Mania.Models;
using Foozball_Mania.Models.DataSource;
using Foozball_Mania.Models.Stats;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Foozball_Mania.Controllers
{
    public class HomeController : Controller
    {

        private IMatchDataSource _db;
        private CRUD _crud = new CRUD();
        private StatsCalculate _stcalc = new StatsCalculate();

        
        //Implement IoC
        public HomeController(IMatchDataSource db)
        {
            _db = db;
        }
        
        public ActionResult Index()
        {
            return View();
    
        }
        
        public JsonResult GetPlayers()
        {
            var allPlayers = _db.Players;
            return Json(allPlayers, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult MatchResult(ResultReturn result)
        {
            if (result != null)
            {
                     
                return Json(_crud.UpdateMatchResult(result));
            }
            else
            {
                return Json("No Result Received");
            }
        }

        public ActionResult Stats()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PlayerSelect(PlayerSelection playerSelection)
        {
            if (playerSelection != null)
            {
                List<WLStat> p1stats = new List<WLStat>();
                if (playerSelection.Player2 == "Empty")
                {
                    //One player stats to be calculated
                    p1stats = _stcalc.OnePlayerStats(playerSelection);
                }
                else
                {
                    //Two player stats to be calculated
                }
                return Json(p1stats, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Something went wrong");
            }
         }
    }
}