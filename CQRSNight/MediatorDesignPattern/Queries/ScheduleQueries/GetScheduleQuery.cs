using CQRSNight.MediatorDesignPattern.Results.ScheduleResult;
using MediatR;

namespace CQRSNight.MediatorDesignPattern.Queries.ScheduleQueries
{
    public class GetScheduleQuery:IRequest<List<GetScheduleQueryResult>>
    {
    }
}
