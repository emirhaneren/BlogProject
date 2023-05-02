using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        //Relation settings (1-N)
        //ICollection
        public List<Comment>? Comments { get; set; }


    }
}
