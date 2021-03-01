using System.Web.Mvc;

namespace Covid19.Controllers
{
    public class PaisesController : Controller
    {
        // GET: Paises
        public ActionResult Index()
        {
            ViewBag.Message = "Casos de Covid-19";

            return View();
        }
    }
}