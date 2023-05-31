using TodoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Data;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
    }
    public DbSet<Todo> Todos { get; set; } = null!;
}