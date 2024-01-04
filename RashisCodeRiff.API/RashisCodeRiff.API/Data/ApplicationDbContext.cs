using Microsoft.EntityFrameworkCore;
using RashisCodeRiff.API.Models.Domain;

namespace RashisCodeRiff.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
