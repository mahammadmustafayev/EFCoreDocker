

using CodeFirstApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApp.Data;

internal class AppDbContext:DbContext
{
    public AppDbContext(){ }
    public DbSet<Country> Countries { get; set; }
    public DbSet<City> Cities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=Northwind; uid=sa;pwd=Alaska2017;TrustServerCertificate=True;");
    }

}
