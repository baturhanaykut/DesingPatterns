using UnitOfWorkDesignPattern.DataAccessLayer.Abstract;
using UnitOfWorkDesignPattern.DataAccessLayer.Concrete;
using UnitOfWorkDesignPattern.DataAccessLayer.Repositories;
using UnitOfWorkDesignPattern.EntityLayer.Concrete;

namespace UnitOfWorkDesignPattern.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>,ICustomerDal
    {
        public EfCustomerDal(Context context) : base(context)
        {
            
        }
    }
}
