using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Serenity.Cinema.Pages
{

    [PageAuthorize(typeof(PersonRow))]
    public class PersonController : Controller
    {
        [Route("Cinema/Person")]
        public ActionResult Index()
        {
            return View("~/Modules/Cinema/Person/PersonIndex.cshtml");
        }
    }
}