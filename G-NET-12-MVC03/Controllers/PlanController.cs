using G_NET_12_MVC03.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace G_NET_12_MVC03.Controllers
{
    public class PlanController : Controller
    {
        private readonly GymDbContext Context;
        public PlanController()
        {
            Context = new GymDbContext();
        }

        public async Task<IActionResult> Index()
        {
            var plans = await Context.Plans.ToListAsync();
            return View();
        }

        public async Task<IActionResult> Details(int id)
        {
            var plan = await Context.Plans.FindAsync(id);
            if (plan == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(plan);
        }
    }
}
