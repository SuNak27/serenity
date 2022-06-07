using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Serenity.Cinema.Pages
{

    [PageAuthorize(typeof(GenreRow))]
    public class GenreController : Controller
    {
        [Route("Cinema/Genre")]
        public ActionResult Index()
        {
            return View("~/Modules/Cinema/Genre/GenreIndex.cshtml");
        }
    }
}