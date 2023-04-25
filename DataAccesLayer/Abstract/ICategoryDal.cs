using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6. Step, Interfaces
// 1. way
//Finally implement generic repository
namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>
    {
        /*
        //ListMethod
        List<Category> ListAllCategory();

        //VoidMethod
        void AddCategory(Category category);
        void DeleteCategory(Category category);
        void UpdateCategory(Category category);

        //OtherMethod
        Category GetById(int id);
        */
    }
}
