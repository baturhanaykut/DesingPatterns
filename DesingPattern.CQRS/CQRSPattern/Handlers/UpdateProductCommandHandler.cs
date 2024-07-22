using DesingPattern.CQRS.CQRSPattern.Commands;
using DesingPattern.CQRS.DAL;

namespace DesingPattern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.ProductID);
            values.Name = command.Name;
            values.Price = command.Price;
            values.Status = true;
            values.Stock = command.Stock;
            values.Description = command.Description;
            _context.SaveChanges();
        }
    }
}
