using System.ComponentModel.DataAnnotations;
//1. Step
namespace EntitiyLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string? BlogTitle { get; set; }
        public string? BlogContent { get; set; }
        public string? BlogThumbnailImage { get; set; }
        public string? BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }

        //Relation settings (N-1)
        //Other table Key
        //add-migration mig2
        public int CategoryID { get; set; }
        public Category? Category { get; set; }
        //add-migration mig3
        public int WriterID { get; set; }
        public Writer? Writer { get; set; }
        //Relation settings (1-N)
        //ICollection
        public List<Comment>? Comments { get; set; }


    }
}
