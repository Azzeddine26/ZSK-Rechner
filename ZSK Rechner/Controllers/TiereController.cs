using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZSK_Rechner.Data;
namespace ZSK_Rechner.Controllers
{
    public class TiereController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TiereController(ApplicationDbContext context)
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
