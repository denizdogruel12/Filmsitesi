using Microsoft.EntityFrameworkCore;

namespace Filmsitesi.Models;
public class FilmContext:DbContext{
    public FilmContext(DbContextOptions<FilmContext> options):base(options){}
    public DbSet<Film> Filmler { get; set; }
}