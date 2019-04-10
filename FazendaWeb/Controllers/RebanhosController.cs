using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FazendaWeb.Models;

namespace FazendaWeb.Controllers
{
    public class RebanhosController : Controller
    {
        private readonly FazendaWebContext _context;

        public RebanhosController(FazendaWebContext context)
        {
            _context = context;
        }

        // GET: Rebanhos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rebanho.ToListAsync());
        }

        // GET: Rebanhos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rebanho = await _context.Rebanho
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rebanho == null)
            {
                return NotFound();
            }

            return View(rebanho);
        }

        // GET: Rebanhos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rebanhos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,DataNascimento,Raca,Sexo,Origem")] Rebanho rebanho)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rebanho);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rebanho);
        }

        // GET: Rebanhos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rebanho = await _context.Rebanho.FindAsync(id);
            if (rebanho == null)
            {
                return NotFound();
            }
            return View(rebanho);
        }

        // POST: Rebanhos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,DataNascimento,Raca,Sexo,Origem")] Rebanho rebanho)
        {
            if (id != rebanho.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rebanho);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RebanhoExists(rebanho.Id))
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
            return View(rebanho);
        }

        // GET: Rebanhos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rebanho = await _context.Rebanho
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rebanho == null)
            {
                return NotFound();
            }

            return View(rebanho);
        }

        // POST: Rebanhos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rebanho = await _context.Rebanho.FindAsync(id);
            _context.Rebanho.Remove(rebanho);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RebanhoExists(int id)
        {
            return _context.Rebanho.Any(e => e.Id == id);
        }
    }
}
