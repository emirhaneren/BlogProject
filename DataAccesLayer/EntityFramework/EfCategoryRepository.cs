using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntitiyLayer.Concrete;
//7. Step, Repos
namespace DataAccessLayer.EntityFramework
{
    //Generic repository and special category repository
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryDal
    {
    }
}
