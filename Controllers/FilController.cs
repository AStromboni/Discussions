using Discussions.Areas.Identity.Data;
using Discussions.Data;
using Discussions.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Discussions.Controllers
{

    public class FilFormModel
    {
        public Communaute Communaute { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Content { get; set; }
    }

    public class FilController : Controller
    {
        private readonly DiscussionsContext context;
        private readonly UserManager<DiscussionsUser> _userManager;

        public FilController(DiscussionsContext context, UserManager<DiscussionsUser> userManager)
        {
            this.context = context;
            _userManager = userManager;
        }

        [Route("Fil")]
        public IActionResult Index()
        {
            return View();
        }


        public async Task<ActionResult> OnGetCreate()
        {
            ViewData.Model = await context.Communaute.ToListAsync();
            return new PartialViewResult
            {
                ViewName = "",
                ViewData = ViewData
            };
        }

        [Route("Fil/Creer")]
        public async Task<IActionResult> Creer(int idCommunaute)
        {

            var communaute = await context.Communaute.Where(c => c.CommunauteId == idCommunaute).SingleAsync();
            ViewBag.Communaute = communaute;
            return View(new Fil { CommunauteId = communaute.CommunauteId });

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Fil/Creer")]
        public async Task<IActionResult> PostCreer(Fil fil)
        {

            string userId = _userManager.GetUserId(User);

            if (ModelState.IsValid)
            {
                fil.CreatedOn = DateTime.UtcNow;
                fil.DiscussionsUserId = userId;

                context.Message.Add(fil);
                await context.SaveChangesAsync();
                return RedirectToAction("Index", "Communaute", new { id = fil.CommunauteId });
            }
            return View();

        }
    }
}
