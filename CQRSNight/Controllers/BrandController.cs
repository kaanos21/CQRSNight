using CQRSNight.CQRSDesignPattern.Commands.BrandCommands;
using CQRSNight.CQRSDesignPattern.Handlers.BrandHandlers;
using CQRSNight.CQRSDesignPattern.Queries.BrandQueries;
using Microsoft.AspNetCore.Mvc;

namespace CQRSNight.Controllers
{
    public class BrandController : Controller
    {
        private readonly GetBrandQueryHandler _getBrandQueryHandler;
        private readonly CreateBrandCommandHandler _createBrandCommandHandler;
        private readonly RemoveBrandCommandHandler _removeBrandCommandHandler;
        private readonly GetBrandByIdQueryHandler _getBrandByIdQueryHandler;
        private readonly UpdateBrandCommandHandler _updateBrandCommandHandler;

        public BrandController(GetBrandQueryHandler getBrandQueryHandler, CreateBrandCommandHandler createBrandCommandHandler, RemoveBrandCommandHandler removeBrandCommandHandler, GetBrandByIdQueryHandler getBrandByIdQueryHandler, UpdateBrandCommandHandler updateBrandCommandHandler)
        {
            _getBrandQueryHandler = getBrandQueryHandler;
            _createBrandCommandHandler = createBrandCommandHandler;
            _removeBrandCommandHandler = removeBrandCommandHandler;
            _getBrandByIdQueryHandler = getBrandByIdQueryHandler;
            _updateBrandCommandHandler = updateBrandCommandHandler;
        }

        public IActionResult Index()
        {
            var vv = _getBrandQueryHandler.Handle();
            return View(vv);
        }
        [HttpGet]
        public IActionResult CreateBrand()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBrand(CreateBrandCommand command)
        {
            _createBrandCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult RemoveBrand(int id)
        {
            _removeBrandCommandHandler.Handle(new RemoveBrandCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateBrand(int id)
        {
            var vv = _getBrandByIdQueryHandler.Handle(new GetBrandByIdQuery(id));
            return View(vv);
        }
        [HttpPost]
        public IActionResult UpdateBrand(UpdateBrandCommand command)
        {
            _updateBrandCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
