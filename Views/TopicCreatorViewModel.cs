using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace _931901.kuznetsov.semyon.lab2._6.Models
{
    public class TopicCreatorViewModel
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

    }
}
