using CQRSNight.MediatorDesignPattern.Results.ScheduleResult;
using MediatR;

namespace CQRSNight.MediatorDesignPattern.Queries.ScheduleQueries
{
    public class GetScheduleByIdQuery:IRequest<GetScheduleByIdQueryResult>
    {
        public GetScheduleByIdQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
