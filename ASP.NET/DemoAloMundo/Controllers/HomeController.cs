﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoAloMundo.Models;

namespace DemoAloMundo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) // Ponto de injeção de dependência via construtor
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        _logger.LogInformation($"{User} acessou o Index"); // appsettings.Development.json está configurado para Information
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}