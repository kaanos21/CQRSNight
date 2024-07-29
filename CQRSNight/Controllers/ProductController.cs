using CQRSNight.CQRSDesignPattern.Handlers.ProductHandlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRSNight.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;

        public ProductController(GetProductQueryHandler getProductQueryHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
        }

        public IActionResult ProductList()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }
    }
}
