using CQRSNight.MediatorDesignPattern.Commands.LocationCommands;
using CQRSNight.MediatorDesignPattern.Queries.LocationQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSNight.Controllers
{
    public class LocationController : Controller
    {
        private readonly IMediator _mediator;

        public LocationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var vv =await _mediator.Send(new GetLocationQuery());
            return View(vv);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateLocationCommand command)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(command);
                return RedirectToAction("Index");
            }
            return View(command);
        }

        public async Task<IActionResult> RemoveLocation(int id)
        {
            await _mediator.Send(new RemoveLocationCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateLocation(int id)
        {
            var vv=await _mediator.Send(new GetLocationByIdQuery(id));
            return View(vv);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateLocation(UpdateLocationCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
    }
}
