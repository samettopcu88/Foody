using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class EfAboutItemDal : GenericRepository<AboutItem>, IAboutItemDal
    {
        public EfAboutItemDal(FoodyContext context) : base(context)
        {
        }
    }
}
