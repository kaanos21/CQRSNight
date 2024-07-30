namespace CQRSNight.CQRSDesignPattern.Queries.BrandQueries
{
    public class GetBrandByIdQuery
    {
        public GetBrandByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
