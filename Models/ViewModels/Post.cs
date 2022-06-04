﻿using System.ComponentModel.DataAnnotations;

namespace _931901.kuznetsov.semyon.lab2._6.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        public string Text { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public int? CategoryId { get; set; }

        public ForumCategory Category { get; set; }
    }
}