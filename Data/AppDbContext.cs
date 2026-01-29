using Microsoft.EntityFrameworkCore;
using TaskManagerApp.Models;

namespace TaskManagerApp.Data;

public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Ye line database mein 'Tasks' naam ki table create karne mein help karegi
    public DbSet<TodoTask> Tasks => Set<TodoTask>();
}
