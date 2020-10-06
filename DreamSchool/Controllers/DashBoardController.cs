using Microsoft.AspNetCore.Mvc;

namespace DreamSchool.Controllers
{
    public class DashBoardController : Controller
    {
        // GET: DashBoard
        public ActionResult Index()
        {
            return View();
        }
    }
}