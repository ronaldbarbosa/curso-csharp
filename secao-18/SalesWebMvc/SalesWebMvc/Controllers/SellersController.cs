using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _selllerService;
        private readonly DepartamentService _departamentService;

        public SellersController(SellerService selllerService, DepartamentService departamentService)
        {
            _selllerService = selllerService;
            _departamentService = departamentService;
        }

        public IActionResult Index()
        {
            var list = _selllerService.FindAll();
            return View(list);
        }

        public IActionResult Create() 
        {
            var departaments = _departamentService.FindAll();
            var viewModel = new SellerFormViewModel { Departaments = departaments};
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller) 
        {
            _selllerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
