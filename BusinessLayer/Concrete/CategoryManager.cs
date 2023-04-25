using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//12.Step Manager class
//Rules and Validation
namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //Create repository
        // CategoryRepository categoryRepository = new CategoryRepository(); (First way)
        // GenericRepository<Category> repo = new GenericRepository<Category>(); (Second way)

        //Create ef-repo (third way)
        // EfCategoryRepository efCategoryRepository;

        ICategoryDal _categoryDal;
       
        //Create constructor
        /* public CategoryManager()
        {
            //efCategoryRepository = new EfCategoryRepository();
        }
        */
        //generate constructor
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddCategory(Category category)
        {
            //Rules
            /*
            if(category.CategoryName!="" && category.CategoryDescription!="" && category.CategoryName.Length>=5 && category.CategoryStatus==true)
            {
                categoryRepository.AddCategory(category);
            }
            else
            {
                //Error message, Fluent validation
            }
            */

            /*
             * efCategoryRepository.Insert(category);
             * */

            _categoryDal.Insert(category);
            
        }

        public void DeleteCategory(Category category)
        {
            //Rules
            /*
            if(category.CategoryID!= 0)
            {
                repo.Delete(category);
            }
            */

            /*
            efCategoryRepository.Delete(category);
            */

            _categoryDal.Delete(category);  
        }

        public Category GetById(int id)
        {
            //Rules
            /*
             * return efCategoryRepository.GetById(id);
             * */

            return _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            //Rules
            /*
             * return efCategoryRepository.GetListAll();
             */

            return _categoryDal.GetListAll();
        }

        public void UpdateCategory(Category category)
        {
            //Rules
            /*
             * efCategoryRepository.Update(category);
             */

            _categoryDal.Update(category);
        }
    }
}
