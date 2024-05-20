using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data;

public class ProjectDbContext : DbContext
{
    protected ProjectDbContext()
    {
    }

    public ProjectDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Project> Projects { get; set; }
}