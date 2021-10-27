using Discussions.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Discussions.Controllers
{
    public class CommunauteController : Controller
    {
        private readonly DiscussionsContext context;

        public CommunauteController(DiscussionsContext context)
        {
            this.context = context;
        }


        // GET: CommunauteController
        [Route("Communaute")]
        [Route("Communaute/Index")]
        public async Task<IActionResult> Index()
        {
            var results = await context.Communaute.
                Include(p => p.Abonnes).
                ToListAsync();
            var converted = results.Select(c => { c.CreationDate = c.CreationDate.ToLocalTime(); return c; });
            return View("Communautes", converted);
        }
        [Route("Communaute/Details")]
        // GET: CommunauteController/Details/5
        public async Task<IActionResult> Details(int idCommunaute)
        {

            var resultats = await context.Communaute
                .Where(c => c.CommunauteId == idCommunaute)
                .Include(c => c.Fils).ThenInclude(f=>f.Author).SingleAsync();

            resultats.CreationDate = resultats.CreationDate.ToLocalTime();

            resultats.Fils = resultats.Fils.Select(c => { c.CreatedOn = c.CreatedOn.ToLocalTime(); return c; }).ToList();
            return View(resultats);
        }

        // GET: CommunauteController/Create
        public ActionResult Create()
        {
            return View();
        }



        // POST: CommunauteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CommunauteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CommunauteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CommunauteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CommunauteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
