using ASP_NET_HW_1.Models;
using ASP_NET_HW_1.Models.Bets.Football;
using ASP_NET_HW_1.Models.Xml;
using System.Web.Mvc;

namespace ASP_NET_HW_1.Controllers
{
    public class HomeController : Controller
    {
        private FootballBetContext _db = new FootballBetContext();

        public ActionResult Index()
        {
            ViewBag.Title = "Тотализатор";
            return View(MyXmlReader.GetGamesSchedule(Server.MapPath("~/App_Data/GamesSchedule.xml")));
        }

        [HttpGet]
        public ActionResult MakeBet(int? id)
        {
            return View(MyXmlReader.GetGameScheduleById(id, Server.MapPath("~/App_Data/GamesSchedule.xml")));
        }

        [HttpPost]
        public ActionResult MakeBet(FootballBet footballBet)
        {
            if (footballBet != null)
            {
                _db.FootballBets.Add(footballBet);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return new HttpNotFoundResult();
        }

        public new void Dispose()
        {
            _db.Dispose();
        }
    }
}