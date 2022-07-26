﻿using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public List<Post> Posts { get; set; }
    }
}
