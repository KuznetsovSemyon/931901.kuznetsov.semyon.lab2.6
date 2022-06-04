using System.ComponentModel.DataAnnotations;

namespace _931901.kuznetsov.semyon.lab2._6.Models
{
    public class ForumCategory
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
    }
}