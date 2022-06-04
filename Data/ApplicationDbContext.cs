using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using _931901.kuznetsov.semyon.lab2._6.Models;

namespace _931901.kuznetsov.semyon.lab2._6.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ForumCategory> ForumCategories { get; set; }
        public DbSet<Post> Posts { get; set; }

        public DbSet<Folder> Folders { get; set; }

        public DbSet<File> Files { get; set; }

        public DbSet<TopicModel> Topics { get; set; }
        public DbSet<TopicCreatorModel> topicCreatorModels { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}