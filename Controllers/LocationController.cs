using Inversity_test.Models;
using Microsoft.AspNetCore.Mvc;
public class LocationController : Controller
{
    private readonly ApplicationDbContext _context;

    public LocationController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: Location/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Location/Create
    [HttpPost]
    public async Task<IActionResult> Create(Location location)
    {
        if (ModelState.IsValid)
        {
            _context.Add(location);
            await _context.SaveChangesAsync();
            return RedirectToAction("InfectionMap", "Home"); // Redirect to the InfectionMap action in HomeController
        }
        return View(location); // Return the same view with the model if validation fails
    }
}
