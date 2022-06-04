using System;
using Microsoft.AspNetCore.Http;

namespace _931901.kuznetsov.semyon.lab2._6.Models
{
    public class FileViewModel
    {
        public string Name { get; set; }
        public IFormFile FilePath { get; set; }
    }
}
