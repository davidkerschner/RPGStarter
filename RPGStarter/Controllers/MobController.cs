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
    public class MobController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MobController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Mob
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mob.ToListAsync());
        }

        // GET: Mob/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mob = await _context.Mob
                .SingleOrDefaultAsync(m => m.MobID == id);
            if (mob == null)
            {
                return NotFound();
            }

            return View(mob);
        }

        // GET: Mob/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mob/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MobID,MobName,ItemID,ItemName,StatID,is_hostile")] Mob mob)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mob);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mob);
        }

        // GET: Mob/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mob = await _context.Mob.SingleOrDefaultAsync(m => m.MobID == id);
            if (mob == null)
            {
                return NotFound();
            }
            return View(mob);
        }

        // POST: Mob/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MobID,MobName,ItemID,ItemName,StatID,is_hostile")] Mob mob)
        {
            if (id != mob.MobID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mob);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MobExists(mob.MobID))
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
            return View(mob);
        }

        // GET: Mob/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mob = await _context.Mob
                .SingleOrDefaultAsync(m => m.MobID == id);
            if (mob == null)
            {
                return NotFound();
            }

            return View(mob);
        }

        // POST: Mob/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mob = await _context.Mob.SingleOrDefaultAsync(m => m.MobID == id);
            _context.Mob.Remove(mob);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MobExists(int id)
        {
            return _context.Mob.Any(e => e.MobID == id);
        }
    }
}
