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

        //Az eszközök kilistázása, query paraméterrel lehet keresni a keresett tárgyak kezdő részleteire
        // GET: Items
        public async Task<IActionResult> Index([FromQuery(Name = "search")] string search)
        {
            int searchLength = 0;

            if (search != null)
            {
                searchLength = search.Length;
            }

            //keresés nélkül
            var eFContext = _context.Items.Include(i => i.ReferencedStorage).Include(i => i.ReferencedStorage.ReferencedRoom);
            if (search == null)
            {
                return View(await eFContext.ToListAsync());
            } 
            //Query-s keresés
            else
            {
                var eFContext2 = _context.Items
                    .Where(p => p.Name.Substring(0, searchLength) == search)
                    .Include(i => i.ReferencedStorage)
                    .Include(i => i.ReferencedStorage.ReferencedRoom);
                return View(await eFContext2.ToListAsync());
            }

        }
    }
}
