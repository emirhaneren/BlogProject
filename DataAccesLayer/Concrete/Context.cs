using EntitiyLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2. Step, (Only Entity Layer)
//ConnectionString Class
//3.Step, Add Referance Entity Layer
namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        //Connection String builder
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //server location; DB name; security
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=DbCoreBlog;integrated security=true;");
        }
        //Add Dbset, single and singles's
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<NewsLetter> newsLetters { get; set; }
        public DbSet<BlogRate> BlogsRate { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}
