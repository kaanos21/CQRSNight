using CQRSNight.CQRSDesignPattern.Handlers.CarHandlers;
using CQRSNight.DTO;
using CQRSNight.MediatorDesignPattern.Queries.CarFilterQueries;
using CQRSNight.MediatorDesignPattern.Queries.LocationQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CQRSNight.Controllers
{
    public class RentACarController : Controller
    {
        private readonly IMediator _mediator;
        private readonly GetCarQueryHandler _getCarQueryHandler;

        public RentACarController(IMediator mediator, GetCarQueryHandler getCarQueryHandler)
        {
            _mediator = mediator;
            _getCarQueryHandler = getCarQueryHandler;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var locations = await _mediator.Send(new GetLocationQuery());
            List<SelectListItem> values = locations.Select(x => new SelectListItem
            {
                Text = x.Address,
                Value = x.Id.ToString()
            }).ToList();
            ViewBag.PickUpLocation = values;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CarList(CarFilterDto carFilterDto)
        {
            var query = new GetCarWithFilterQuery(
                carFilterDto.PickUpLocationId,
                carFilterDto.PickUpDate,
                carFilterDto.DropOffDate
            );

            var cars = await _mediator.Send(query);

            // Arabaları istediğiniz bir kritere göre sıralayabilirsiniz, örneğin fiyata göre:


            return View(cars);
        }
    }
}
