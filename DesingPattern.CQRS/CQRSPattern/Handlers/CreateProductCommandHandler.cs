using DesingPattern.CQRS.CQRSPattern.Commands;
using DesingPattern.CQRS.DAL;

namespace DesingPattern.CQRS.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand createProductCommand)
        {
            _context.Products.Add(new Product
            {
                Name = createProductCommand.Name,
                Price = createProductCommand.Price,
                Description = createProductCommand.Description,
                Status = true,
                Stock = createProductCommand.Stock,
            });
            _context.SaveChanges();
        }
    }
}
