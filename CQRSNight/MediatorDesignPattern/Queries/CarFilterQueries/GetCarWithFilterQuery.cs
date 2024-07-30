using CQRSNight.Dal.Entities;
using CQRSNight.MediatorDesignPattern.Results.CarFilterResult;
using MediatR;

namespace CQRSNight.MediatorDesignPattern.Queries.CarFilterQueries
{
    public class GetCarWithFilterQuery:IRequest<List<Car>>
    {
        public GetCarWithFilterQuery(int pickUpLocationId, DateTime pickUpDate, DateTime dropOffDate)
        {
            PickUpLocationId = pickUpLocationId;
            PickUpDate = pickUpDate;
            DropOffDate = dropOffDate;
        }

        public int PickUpLocationId { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
    }
}
