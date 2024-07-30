using CQRSNight.CQRSDesignPattern.Commands.CarCommands;
using CQRSNight.CQRSDesignPattern.Handlers.CarHandlers;
using CQRSNight.CQRSDesignPattern.Handlers.CarHandlers;
using CQRSNight.CQRSDesignPattern.Queries.CarQueries;
using Microsoft.AspNetCore.Mvc;

namespace CQRSNight.Controllers
{
    public class CarController : Controller
    {
        private readonly GetCarQueryHandler _getCarQueryHandler;
        private readonly CreateCarCommandHandler _createCarCommandHandler;
        private readonly RemoveCarCommandHandler _removeCarCommandHandler;
        private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;
        private readonly UpdateCarCommandHandler _updateCarCommandHandler;

        public CarController(GetCarQueryHandler getCarQueryHandler, CreateCarCommandHandler createCarCommandHandler, RemoveCarCommandHandler removeCarCommandHandler, GetCarByIdQueryHandler getCarByIdQueryHandler, UpdateCarCommandHandler updateCarCommandHandler)
        {
            _getCarQueryHandler = getCarQueryHandler;
            _createCarCommandHandler = createCarCommandHandler;
            _removeCarCommandHandler = removeCarCommandHandler;
            _getCarByIdQueryHandler = getCarByIdQueryHandler;
            _updateCarCommandHandler = updateCarCommandHandler;
        }

        public IActionResult Index()
        {
            var vv = _getCarQueryHandler.Handle();
            return View(vv);
        }
        [HttpGet]
        public IActionResult CreateCar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCar(CreateCarCommand command)
        {
            _createCarCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult RemoveCar(int id)
        {
            _removeCarCommandHandler.Handle(new RemoveCarCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCar(int id)
        {
            var vv = _getCarByIdQueryHandler.Handle(new GetCarByIdQuery(id));
            return View(vv);
        }
        [HttpPost]
        public IActionResult UpdateCar(UpdateCarCommand command)
        {
            _updateCarCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}

