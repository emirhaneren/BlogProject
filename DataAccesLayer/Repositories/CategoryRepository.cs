using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//7. Step, Repos
namespace DataAccessLayer.Repositories
{
    //Implement Interface
    public class CategoryRepository : ICategoryDal
    {
        //new method
        Context c = new Context();
        //CRUD -Create -Read -Update -Delete
        public void AddCategory(Category category)
        {
            c.Add(category);
            c.SaveChanges();
        }
        public void DeleteCategory(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }
        public Category GetById(int id)
        {//Linq ?
            return c.Categories.Find(id);
        }
        public void UpdateCategory(Category category)
        {
            c.Update(category);
            c.SaveChanges();
        }
        public List<Category> ListAllCategory()
        {
            return c.Categories.ToList();
        }
        //ef repo methods
        public void Delete(Category t)
        {
            throw new NotImplementedException();
        }
        public List<Category> GetListAll()
        {
            throw new NotImplementedException();
        }
        public void Insert(Category t)
        {
            throw new NotImplementedException();
        }
        public void Update(Category t)
        {
            throw new NotImplementedException();
        }

        
    }
}
