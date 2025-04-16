using System.Threading.Tasks;
using Filmsitesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Filmsitesi.Controllers;
public class FilmController:Controller{
    public readonly FilmContext _context;
    public FilmController(FilmContext context){
        _context=context;

    }
[HttpGet]
    public IActionResult Create(){
        return View();
    }
    [HttpPost]
     public async Task<IActionResult> Create(Film filmsitesi){
        _context.Add(filmsitesi);
        await  _context.SaveChangesAsync();
        return View();
    }
}