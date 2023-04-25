using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6. Step, Interfaces
namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        //ListMethod
        List<Category> ListAllCategory();
        //VoidMethod
        void AddCategory(Category category);
        void DeleteCategory(Category category);
        void UpdateCategory(Category category);
        //OtherMethod
        Category GetById(int id);
    }
}
