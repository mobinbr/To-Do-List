using Microsoft.EntityFrameworkCore;
using classlib;
public class ItemsContext : DbContext
{
    public ItemsContext(DbContextOptions<ItemsContext> options)
            : base(options)
        {
            
        }
    public DbSet<ToDoItems> items{get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
        optionsBuilder.UseSqlite(@"Data Source=ToDoItems.db");
    }
}