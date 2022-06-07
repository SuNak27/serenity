using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Serenity.Cinema.Pages
{

    [PageAuthorize(typeof(MoviecastRow))]
    public class MoviecastController : Controller
    {
        [Route("Cinema/Moviecast")]
        public ActionResult Index()
        {
            return View("~/Modules/Cinema/Moviecast/MoviecastIndex.cshtml");
        }
    }
}