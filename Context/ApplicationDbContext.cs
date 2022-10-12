using csharp_boolflix.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace csharp_boolflix.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Film> Films { get; set; }
    public DbSet<TvShow> TvShows { get; set; }
    public DbSet<Episode> Episodes { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Actor> Actors { get; set; }
    
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlServer
        (
            "Data Source=localhost;Initial Catalog=db-boolflix;Integrated Security=True"
        );
    }
}