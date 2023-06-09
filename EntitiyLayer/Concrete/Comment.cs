﻿using System.ComponentModel.DataAnnotations;
//1. Step
namespace EntitiyLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string? CommentUserName { get; set; }
        public string? CommentTitle { get; set; }
        public string? CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public int? BlogScore { get; set; }
        public bool CommentStatus { get; set; }

        //Relation settings (N-1)
        //Other table Key
        //add-migration mig3
        public int BlogID { get; set; }
        public Blog? Blog { get; set; }

    }
}
