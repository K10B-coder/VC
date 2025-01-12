using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using Inversity_test.Models;
using Microsoft.Extensions.Hosting;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var locations = await _context.Locations.ToListAsync();
        return View(locations);
    }

    public async Task<IActionResult> InfectionMap()
    {
        var locations = await _context.Locations.ToListAsync();
        return View(locations);
    }
public IActionResult Navigate()
    {
        return View();
    }

    public IActionResult Education()
    {
        var diseases = new List<Disease>
        {
            new Disease
            {
                Id = 1,
                Name = "Influenza",
                Severity = "Medium",
                Symptoms = new List<string> { "Fever", "Cough", "Fatigue" },
                Description = "A common viral infection that affects the respiratory system."
            },
            new Disease
            {
                Id = 2,
                Name = "Common Cold",
                Severity = "Low",
                Symptoms = new List<string> { "Runny nose", "Sore throat", "Mild cough" },
                Description = "A mild viral infection affecting the upper respiratory tract."
            },
            new Disease
            {
                Id = 3,
                Name = "COVID19",
                Severity = "High",
                Symptoms = new List<string> { "Fever", "Shortness of Breath", "Mild cough", "Chills" },
                Description = "A mild viral infection affecting the upper respiratory tract."
            },
            new Disease
            {
                Id = 4,
                Name = "NoroVirus",
                Severity = "High",
                Symptoms = new List<string> { "Fever", "Muscle Aches", "Fatigue", "Headaches" },
                Description = "A highly contagious virus that causes gastroenteritis (inflammation of the stomach and intestines)."
            },
            new Disease
            {
                Id = 5,
                Name = "Heatstroke",
                Severity = "Medium",
                Symptoms = new List<string> { "Dry Skin", "Confusion", "Fainting", "High body temperature" },
                Description = "A medical event which occurs when the body is unable to regulate its temperature in extremely hot conditions."
            }
            // Add more diseases as needed
        };

        return View(diseases);
    }


public IActionResult About()
    {
    return View();
    }
}
