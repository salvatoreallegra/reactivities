using System;
using Microsoft.EntityFrameworkCore;
using Domain;
namespace Persistence
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        // Database context implementation
        public DbSet<Activity> Activities { get; set; }
    }
}