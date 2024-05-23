using Business.Abstract;
using DataAccess.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationEuroDoor.Controllers
{
   
    public class SalerController : Controller
    {
        private readonly IDetallarService _detallar;

        public SalerController(IDetallarService detallar)
        {
            _detallar = detallar;
        }

        public IActionResult SalerProduct()
        {
            var values = _detallar.GetAll();
            return View(values);
        }
    }
}
