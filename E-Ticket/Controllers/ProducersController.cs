using E_Ticket.Data;
using E_Ticket.Data.Services;
using E_Ticket.Data.Static;
using E_Ticket.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace E_Ticket.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;
        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync();
            return View(allProducers);
        }

        //Get: producers/details/1
        [AllowAnonymous]
        public async Task<ActionResult> Details(int id)
        {

            var producersDetails = await _service.GetByIdAsync(id);
            if (producersDetails == null) return View("NotFound");
            return View(producersDetails);
        }

        //GET: producers/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);

            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }

        //Get: producers/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var producersDetails = await _service.GetByIdAsync(id);
            if (producersDetails == null) return View("NotFound");

            return View(producersDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);

            if (id == producer.Id)
            {
                await _service.UpdateAsync(id, producer);
                return RedirectToAction(nameof(Index));
            }
            return View(producer);

        }

        //Get: producers/delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var producersDetails = await _service.GetByIdAsync(id);
            if (producersDetails == null) return View("NotFound");

            return View(producersDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producersDetails = await _service.GetByIdAsync(id);
            if (producersDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
    //public class ProducersController : Controller
    //{
    //    private readonly AppDbContext _context;
    //    public ProducersController(AppDbContext context)
    //    {
    //        _context = context;

    //    }
    //    public async Task<IActionResult> Index()
    //    {
    //        var allProducers = await _context.Producers.ToListAsync();
    //        return View(allProducers);
    //    }
    //}
}
