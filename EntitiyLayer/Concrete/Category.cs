﻿using System.ComponentModel.DataAnnotations;
//1. Step
namespace EntitiyLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }

        //Relationship 1-N
        //ICollection
        public List<Blog>? Blogs { get; set; }
    }
}
