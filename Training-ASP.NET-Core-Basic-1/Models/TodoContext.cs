using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace Training_ASP.NET_Core_Basic_1.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        { 
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
