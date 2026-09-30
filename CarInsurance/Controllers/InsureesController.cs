using CarInsurance.Data;
using CarInsurance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace CarInsurance.Controllers;
public class InsureesController : Controller
{
    private readonly ApplicationDbContext _context;
    public InsureesController(ApplicationDbContext context) => _context = context;
    public async Task<IActionResult> Index() => View(await _context.Insurees.ToListAsync());
    public async Task<IActionResult> Admin() => View(await _context.Insurees.OrderByDescending(x => x.Id).ToListAsync());
    public async Task<IActionResult> Details(int? id) { if (id == null) return NotFound(); var x=await _context.Insurees.FirstOrDefaultAsync(m=>m.Id==id); return x==null?NotFound():View(x); }
    public IActionResult Create() => View();
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
    {
        if (ModelState.IsValid) { insuree.Quote=CalculateQuote(insuree); _context.Add(insuree); await _context.SaveChangesAsync(); return RedirectToAction(nameof(Index)); }
        return View(insuree);
    }
    public async Task<IActionResult> Edit(int? id) { if(id==null)return NotFound(); var x=await _context.Insurees.FindAsync(id); return x==null?NotFound():View(x); }
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id,[Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
    {
        if(id!=insuree.Id)return NotFound();
        if(ModelState.IsValid){ try { insuree.Quote=CalculateQuote(insuree); _context.Update(insuree); await _context.SaveChangesAsync(); } catch(DbUpdateConcurrencyException){ if(!InsureeExists(insuree.Id))return NotFound(); throw; } return RedirectToAction(nameof(Index)); } return View(insuree);
    }
    public async Task<IActionResult> Delete(int? id){ if(id==null)return NotFound(); var x=await _context.Insurees.FirstOrDefaultAsync(m=>m.Id==id); return x==null?NotFound():View(x); }
    [HttpPost,ActionName("Delete"),ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id){ var x=await _context.Insurees.FindAsync(id); if(x!=null)_context.Insurees.Remove(x); await _context.SaveChangesAsync(); return RedirectToAction(nameof(Index)); }
    private bool InsureeExists(int id)=>_context.Insurees.Any(e=>e.Id==id);
    private static decimal CalculateQuote(Insuree x)
    {
        decimal quote=50m;
        var today=DateTime.Today; int age=today.Year-x.DateOfBirth.Year; if(x.DateOfBirth.Date>today.AddYears(-age))age--;
        if(age<=18) quote+=100m; else if(age<=25) quote+=50m; else quote+=25m;
        if(x.CarYear<2000) quote+=25m; if(x.CarYear>2015) quote+=25m;
        if(x.CarMake.Equals("Porsche",StringComparison.OrdinalIgnoreCase)){ quote+=25m; if(x.CarModel.Equals("911 Carrera",StringComparison.OrdinalIgnoreCase))quote+=25m; }
        quote+=x.SpeedingTickets*10m;
        if(x.DUI) quote*=1.25m;
        if(x.CoverageType) quote*=1.50m;
        return Math.Round(quote,2);
    }
}
