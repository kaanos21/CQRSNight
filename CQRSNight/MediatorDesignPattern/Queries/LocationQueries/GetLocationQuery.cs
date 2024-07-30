using CQRSNight.MediatorDesignPattern.Results.LocationResult;
using MediatR;

namespace CQRSNight.MediatorDesignPattern.Queries.LocationQueries
{
    public class GetLocationQuery: IRequest<List<GetLocationQueryResult>>
    {
    }
}
