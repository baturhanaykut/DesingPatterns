using UnitOfWorkDesignPattern.DataAccessLayer.Abstract;
using UnitOfWorkDesignPattern.DataAccessLayer.Concrete;
using UnitOfWorkDesignPattern.DataAccessLayer.Repositories;
using UnitOfWorkDesignPattern.EntityLayer.Concrete;

namespace UnitOfWorkDesignPattern.DataAccessLayer.EntityFramework
{
    public class EfProcessDal : GenericRepository<Process>, IProcessDal
    {
        public EfProcessDal(Context context) : base(context)
        {

        }
    }
}