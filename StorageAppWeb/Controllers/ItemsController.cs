using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StorageAppWeb.Context;
using StorageAppWeb.Models;

namespace StorageAppWeb.Controllers
{
    public class ItemsController : Controller
    {
        private readonly EFContext _context;

        public ItemsController(EFContext context)
        {
            _context = context;
        }

        // GET: Items
        public async Task<IActionResult> Index([FromQuery(Name = "search")] string search)
        {
            int searchLength = 0;

            if (search != null)
            {
                searchLength = search.Length;
            }

            //_context.Storages.Include(x => x.ReferencedRoom);
            //_context.Rooms.Load();
            var eFContext = _context.Items.Include(i => i.ReferencedStorage).Include(i => i.ReferencedStorage.ReferencedRoom);
            //var eFContext = _context.Items;
            if (search == null)
            {
                return View(await eFContext.ToListAsync());
            } else
            {
                var eFContext2 = _context.Items
                    .Where(p => p.Name.Substring(0, searchLength) == search)
                    .Include(i => i.ReferencedStorage)
                    .Include(i => i.ReferencedStorage.ReferencedRoom);
                return View(await eFContext2.ToListAsync());
            }



        }

        // GET: Items/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items
                .Include(i => i.ReferencedStorage)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: Items/Create
        public IActionResult Create()
        {
            ViewData["StorageId"] = new SelectList(_context.Storages, "Id", "Name");
            return View();
        }

        // POST: Items/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Quantity,StorageId")] Item item)
        {
            if (ModelState.IsValid)
            {
                _context.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StorageId"] = new SelectList(_context.Storages, "Id", "Name", item.StorageId);
            return View(item);
        }

        // GET: Items/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            ViewData["StorageId"] = new SelectList(_context.Storages, "Id", "Name", item.StorageId);
            return View(item);
        }

        // POST: Items/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Quantity,StorageId")] Item item)
        {
            if (id != item.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(item.Id))
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
            ViewData["StorageId"] = new SelectList(_context.Storages, "Id", "Name", item.StorageId);
            return View(item);
        }

        // GET: Items/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items
                .Include(i => i.ReferencedStorage)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.Items.FindAsync(id);
            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemExists(int id)
        {
            return _context.Items.Any(e => e.Id == id);
        }
    }
}
