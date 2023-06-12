using EntitiyLayer.Concrete;
using Microsoft.EntityFrameworkCore;
//2. Step, (Only Entity Layer)
//ConnectionString Class
//3.Step, Add Referance Entity Layer
namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        //Connection String builder
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //server location; DB name; security
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=DbCoreBlog;integrated security=true;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message2>()
                .HasOne(x => x.SenderUser)
                .WithMany(y => y.WriterSender)
                .HasForeignKey(z => z.SenderID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>()
                .HasOne(x => x.ReceiverUser)
                .WithMany(y => y.WriterReceiver)
                .HasForeignKey(z => z.ReceiverID)
                .OnDelete(DeleteBehavior.ClientSetNull);
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
        public DbSet<Message> Messages { get; set; }
        public DbSet<Message2> Message2s { get; set; }
    }
}
