using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationEuroDoor.Controllers
{
    public class ModeratorController : Controller
    {
        private readonly IDetallarService _detallar;

        public ModeratorController(IDetallarService detallar)
        {
            _detallar = detallar;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ModeratorProduct()
        {
            var values=_detallar.GetAll();
            return View(values);
        }

    }
}
