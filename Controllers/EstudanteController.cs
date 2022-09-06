using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewsModels;

namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller 
{
    private static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel> 
    {
        new EstudanteViewModel(1, "Sabriha Lindinha", "Rua Augusta", false),
        new EstudanteViewModel(2, "Thigas", "Rua Augusta", true),
        new EstudanteViewModel(3, "Keke", "Rua Rato", true),
        new EstudanteViewModel(4, "Jessiquinha", "Rua Canide", false),
        new EstudanteViewModel(5, "Latorrinho", "Rua Propa", true)
    };

    public IActionResult Index()
    {
        return View(estudantes);
    }

    public IActionResult Show(int id)
    {
        return View(estudantes[id-1]);
    }
}