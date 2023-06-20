using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using MessagePack.Formatters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NuGet.Packaging;
using NuGet.Protocol;
using Project_StarWarsAPI_MVC.Data;
using Project_StarWarsAPI_MVC.Models.Content;

namespace Project_StarWarsAPI_MVC.Controllers
{
    public class StarshipsController : Controller
    {
        private readonly SWContext _context;

        public StarshipsController(SWContext context)
        {
            _context = context;
        }

        // GET: Starships
        public async Task<IActionResult> Index()
        {
              return _context.Starship != null ? 
                          View(await _context.Starship.ToListAsync()) :
                          Problem("Entity set 'SWContext.Starship'  is null.");
        }

        // GET: Starships/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Starship == null)
            {
                return NotFound();
            }

            var starship = await _context.Starship
                .FirstOrDefaultAsync(m => m.Id == id);
            if (starship == null)
            {
                return NotFound();
            }

            return View(starship);
        }

        // GET: Starships/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Starships/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,name,model,manufacturer,cost_in_credits,length,max_atmosphering_speed,crew,passengers,cargo_capacity,consumables,hyperdrive_rating,MGLT,starship_class,created,edited,url")] Starship starship)
        {
            if (ModelState.IsValid)
            {
                _context.Add(starship);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(starship);
        }

        // GET: Starships/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Starship == null)
            {
                return NotFound();
            }

            var starship = await _context.Starship.FindAsync(id);
            if (starship == null)
            {
                return NotFound();
            }
            return View(starship);
        }

        // POST: Starships/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,name,model,manufacturer,cost_in_credits,length,max_atmosphering_speed,crew,passengers,cargo_capacity,consumables,hyperdrive_rating,MGLT,starship_class,created,edited,url")] Starship starship)
        {
            if (id != starship.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(starship);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StarshipExists(starship.Id))
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
            return View(starship);
        }

        // GET: Starships/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Starship == null)
            {
                return NotFound();
            }

            var starship = await _context.Starship
                .FirstOrDefaultAsync(m => m.Id == id);
            if (starship == null)
            {
                return NotFound();
            }

            return View(starship);
        }

        // POST: Starships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Starship == null)
            {
                return Problem("Entity set 'SWContext.Starship'  is null.");
            }
            var starship = await _context.Starship.FindAsync(id);
            if (starship != null)
            {
                _context.Starship.Remove(starship);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StarshipExists(int id)
        {
          return (_context.Starship?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        ////convert image to byte array
        //public byte[] imgToByteArray(HttpPostedFileBase photoInput)
        //{
        //    byte[] byteArray;
        //    using (BinaryReader reader = new BinaryReader(photoInput.InputStream))
        //    {
        //        byteArray = reader.ReadBytes(photoInput.ContentLength);
        //    }
        //    return byteArray;
        //}

        ////Convert byte array to image
        //public ActionResult byteToImg(int Id)
        //{
        //    Starship image = _context.Starship.Find(Id);
        //    byte[] byteArray = image.image;
        //    return File(byteArray, "image/jpeg");
        //}
    }
}
