using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZSK_Rechner.Models;
namespace ZSK_Rechner.Controllers
{
    public class TiereController : Controller
    {
        private readonly ZSK_RechnerDbContext _context;
        public TiereController(ZSK_RechnerDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var tierListe = await _context.Tiere.ToListAsync();
            return View(tierListe);
        }
        
    }
}
