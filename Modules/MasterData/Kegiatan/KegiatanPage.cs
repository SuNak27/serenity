using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Serenity.MasterData.Pages
{

    [PageAuthorize(typeof(KegiatanRow))]
    public class KegiatanController : Controller
    {
        [Route("MasterData/Kegiatan")]
        public ActionResult Index()
        {
            return View("~/Modules/MasterData/Kegiatan/KegiatanIndex.cshtml");
        }
    }
}