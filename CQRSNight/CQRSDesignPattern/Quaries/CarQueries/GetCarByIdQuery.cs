namespace CQRSNight.CQRSDesignPattern.Queries.CarQueries
{
    public class GetCarByIdQuery
    {
        public GetCarByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
