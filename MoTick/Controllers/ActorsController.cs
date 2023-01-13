using Microsoft.AspNetCore.Mvc;
using MoTick.Data;
using MoTick.Data.Services;
using MoTick.Models;

namespace MoTick.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorService _service;
        public ActorsController(IActorService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Biography")]Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
            
        }
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if(actorDetails == null)
            {
                return View("Not Found");
            }
            return View(actorDetails);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
            {
                return View("Not Found");
            }
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id, FullName, ProfilePictureURL, Biography")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
            {
                return View("Not Found");
            }
            return View(actorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
            {
                return View("Not Found");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }
    }
}
