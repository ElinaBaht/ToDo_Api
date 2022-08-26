using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; } = null!;
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        
    }
}
