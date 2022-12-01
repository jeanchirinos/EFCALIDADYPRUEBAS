using System.Diagnostics;
using Calidad20222.web.Helper;
using Microsoft.AspNetCore.Mvc;
using Calidad20222.web.Models;
using Calidad20222.web.Services;
using Microsoft.VisualBasic.CompilerServices;

namespace Calidad20222.web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(new List<Carta>());
    }
    
    [HttpPost]
    public IActionResult Generar()
    {
        var service = new PokerService();
        var cartas = GeneradorMano.Generar();
        ViewBag.Jugada = service.GetJugada(cartas);
        return View("Index", cartas);
    }
    
    //DEFINIR JUGADA
    [HttpPost]
    public IActionResult Definir(string carta1_numero, string carta2_numero, string carta3_numero, 
        string carta4_numero, string carta5_numero, string carta1_palo, string carta2_palo, 
        string carta3_palo, string carta4_palo, string carta5_palo)
    {
        
        var service = new PokerService();
        
        var cartas = new List<Carta>();
        cartas.Add(new Carta() {Palo = carta1_palo, Numero = Int16.Parse(carta1_numero)});
        cartas.Add(new Carta() {Palo = carta2_palo, Numero = Int16.Parse(carta2_numero)});
        cartas.Add(new Carta() {Palo = carta3_palo, Numero = Int16.Parse(carta3_numero)});
        cartas.Add(new Carta() {Palo = carta4_palo, Numero = Int16.Parse(carta4_numero)});
        cartas.Add(new Carta() {Palo = carta5_palo, Numero = Int16.Parse(carta5_numero)});

        
        ViewBag.Jugada = service.GetJugada(cartas);
        return View("Index", cartas);

    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}