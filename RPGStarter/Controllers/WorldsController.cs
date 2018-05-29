using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RPGStarter.Data;
using RPGStarter.Models;

namespace RPGStarter.Controllers
{
    public class WorldsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WorldsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Worlds
        public async Task<IActionResult> Index()
        {
            return View(await _context.World.ToListAsync());
        }

        // GET: Worlds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var world = await _context.World
                .SingleOrDefaultAsync(m => m.worldID == id);
            if (world == null)
            {
                return NotFound();
            }

            return View(world);
        }

        // GET: Worlds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Worlds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("worldID,roomName,roomDesc,eventID")] World world)
        {
            if (ModelState.IsValid)
            {
                _context.Add(world);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(world);
        }

        // GET: Worlds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var world = await _context.World.SingleOrDefaultAsync(m => m.worldID == id);
            if (world == null)
            {
                return NotFound();
            }
            return View(world);
        }

        // POST: Worlds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("worldID,roomName,roomDesc,eventID")] World world)
        {
            if (id != world.worldID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(world);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorldExists(world.worldID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(world);
        }

        // GET: Worlds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var world = await _context.World
                .SingleOrDefaultAsync(m => m.worldID == id);
            if (world == null)
            {
                return NotFound();
            }

            return View(world);
        }

        // POST: Worlds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var world = await _context.World.SingleOrDefaultAsync(m => m.worldID == id);
            _context.World.Remove(world);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorldExists(int id)
        {
            return _context.World.Any(e => e.worldID == id);
        }
    }
}
