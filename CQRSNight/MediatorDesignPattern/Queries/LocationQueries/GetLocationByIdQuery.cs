using CQRSNight.MediatorDesignPattern.Results.LocationResult;
using MediatR;

namespace CQRSNight.MediatorDesignPattern.Queries.LocationQueries
{
    public class GetLocationByIdQuery : IRequest<GetLocationByIdQueryResult>
    {
        public GetLocationByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
