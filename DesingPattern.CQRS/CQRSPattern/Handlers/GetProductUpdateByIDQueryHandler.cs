using DesingPattern.CQRS.CQRSPattern.Queries;
using DesingPattern.CQRS.CQRSPattern.Results;
using DesingPattern.CQRS.DAL;

namespace DesingPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateQueryResult Handle(GetProductUpdateByIDQuery query)
        {
            var values = _context.Products.Find(query.ID);
            return new GetProductUpdateQueryResult
            {
                Description = values.Description,
                ProductID = values.ProductID,
                Name = values.Name,
                Price = values.Price,
                Stock = values.Stock,
            };
        }
    }
}
