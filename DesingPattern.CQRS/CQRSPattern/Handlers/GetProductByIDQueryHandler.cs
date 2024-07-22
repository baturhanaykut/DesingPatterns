using DesingPattern.CQRS.CQRSPattern.Queries;
using DesingPattern.CQRS.CQRSPattern.Results;
using DesingPattern.CQRS.DAL;

namespace DesingPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductByIDQueryResult Handle(GetProductByIDQuery query)
        {
            var values = _context.Set<Product>().Find(query.Id);
            return new GetProductByIDQueryResult
            {
                Name = values.Name,
                Price = values.Price,
                ProductID = values.ProductID,
                Stock = values.Stock
            };
    }
    }
}
