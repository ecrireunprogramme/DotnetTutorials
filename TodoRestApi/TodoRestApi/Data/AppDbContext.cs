using System;
using Microsoft.EntityFrameworkCore;
using TodoRestApi.Data.Models;

namespace TodoRestApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}
