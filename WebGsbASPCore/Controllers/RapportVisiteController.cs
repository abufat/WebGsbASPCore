
using System.Data;
using Microsoft.AspNetCore.Mvc;
using WebGsbAspCore.Models.Dao;

namespace WebGsbASPCore.Controllers
{
    public class RapportVisiteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Rechercher()
        {

            DataTable dt = ServiceRapportVisite.GetTousLesIdRapport();
            ViewBag.Titres = dt;
            return View();
        }
    }

}
