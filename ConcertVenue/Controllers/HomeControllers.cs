using Microsoft.AspNetCore.Mvc;

namespace ConcertVenue.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}