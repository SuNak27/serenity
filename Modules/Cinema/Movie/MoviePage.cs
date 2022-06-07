using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Serenity.Cinema.Pages
{

    [PageAuthorize(typeof(MovieRow))]
    public class MovieController : Controller
    {
        [Route("Cinema/Movie")]
        public ActionResult Index()
        {
            return View("~/Modules/Cinema/Movie/MovieIndex.cshtml");
        }
    }
}