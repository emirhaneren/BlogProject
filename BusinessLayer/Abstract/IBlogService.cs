﻿using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//11. Step Business Layer
namespace BusinessLayer.Abstract
{
	public interface IBlogService : IGenericService<Blog>
	{
		//void AddBlog(Blog blog);
		//void DeleteBlog(Blog blog);
		//void UpdateBlog(Blog blog);
		//List<Blog> GetList();
		//Blog GetById(int id);
		List<Blog> GetBlogListWithCategory();
		List<Blog> GetBlogListByWriter(int id);
	}
}
