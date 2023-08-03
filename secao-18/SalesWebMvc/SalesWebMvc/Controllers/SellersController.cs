using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SelllerService _selllerService;

        public SellersController(SelllerService selllerService)
        {
            _selllerService = selllerService;
        }

        public IActionResult Index()
        {
            var list = _selllerService.FindAll();
            return View(list);
        }
    }
}
