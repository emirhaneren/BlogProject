using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6. Step, Interfaces
namespace DataAccessLayer.Abstract
{
    public interface IBlogDal
    {
        //ListMethod
        List<Blog> ListAllBlog();
        //VoidMethod
        void AddBlog(Blog blog);
        void DeleteBlog(Blog blog);
        void UpdateBlog(Blog blog);
        //Other GetMethod
        Blog GetById(int id);
    }
}
