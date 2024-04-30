using BlazorApp2.Components;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Models
{
    public class TodoDbContext : DbContext
    {
        public DbSet<BlazorApp2.Models.Entity.TodoItem> TodoItems { get; set; }
        public TodoDbContext(DbContextOptions<TodoDbContext> options):base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<TodoItem>().HasData();
            //base.OnModelCreating(modelBuilder);
        }
    }
}
