using System.ComponentModel.DataAnnotations;

namespace Filmsitesi.Models;
public class Film{
    [Key]
    public int ID { get; set; }
    public string? Filmad { get; set; }
    public string? FilmÖzet { get; set; }
    public DateTime Vizyontarihi { get; set; }
    public bool Active { get; set; }
}