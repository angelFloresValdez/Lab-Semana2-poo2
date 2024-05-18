using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyFirstProyectWithLineCommand.Models;

namespace MyFirstProyectWithLineCommand.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult StudentList()
    {
        StundetModel alumno=new StundetModel(); 
        alumno.Nombre="Ángel Flores Valdez";
        alumno.Carrera="Ingenieria en Tecnologias de la información";

        alumno.Fechacreacion=new DateTime(2024,05,17);
        return View(alumno);
    }
     public IActionResult ListaProfesores()
    {
        ProfeModel profe=new ProfeModel();
        profe.Nombre="Ricardo Elizalde";
        profe.Carrera="P002";
        return View(profe);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
     public IActionResult DegreeList()
    {
        DegreeModel Carrera=new DegreeModel();  
        Carrera.Nombre="Ingenieria en TI";

        return View(Carrera);
    }
}
