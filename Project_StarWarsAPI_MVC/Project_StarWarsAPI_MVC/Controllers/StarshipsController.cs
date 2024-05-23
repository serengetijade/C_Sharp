using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_StarWarsAPI_MVC.Data;
using Project_StarWarsAPI_MVC.Models.Swapi;

namespace Project_StarWarsAPI_MVC.Controllers
{
    public class StarshipsController : Controller
    {
        private readonly SWContext _context;

        public StarshipsController(SWContext context)
        {
            _context = context;
        }

        //Update Index method to enable searching: 
        public async Task<IActionResult> Index(string searchString)
        {
            var items = from m in _context.Starship select m;

            //Add basic input sanitization: 
            if (!String.IsNullOrEmpty(searchString) && !searchString.Contains("@") && !searchString.Contains("=") && !searchString.Contains("--"))
            {
                items = items.Where(s => s.Name!.Contains(searchString));
                return View(await items.ToListAsync());
            }

            //Display in alphabetical order: 
            return _context.Starship != null ?
                          View(await _context.Starship.OrderBy(Starship => Starship.Name).ToListAsync()) :
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,image,imageFile,name,model,manufacturer,cost_in_credits,length,max_atmosphering_speed,crew,passengers,cargo_capacity,consumables,hyperdrive_rating,MGLT,starship_class,_pilots,_films,created,edited,url")] Starship starship)
        {
            string? extension = Path.GetExtension(starship.imageFile?.FileName);

            if (ModelState.IsValid && (extension == null || extension.ToLower().Equals(".jpg") || extension.ToLower().Equals(".jpeg") || extension.ToLower().Equals(".png") || extension.ToLower().Equals(".jfif")))
            {
                if (starship.imageFile != null)
                {
                    starship.Image = ImageToByteArray(starship.imageFile);
                }
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,image,imageFile,name,model,manufacturer,cost_in_credits,length,max_atmosphering_speed,crew,passengers,cargo_capacity,consumables,hyperdrive_rating,MGLT,starship_class,_pilots,_films,created,edited,url")] Starship starship)
        {
            if (id != starship.Id)
            {
                return NotFound();
            }
            
            if (ModelState.IsValid)
            {
                try
                {
                    if (starship.imageFile != null)
                    {
                        string extension = Path.GetExtension(starship.imageFile.FileName);
                        if (extension.ToLower().Equals(".jpg") || extension.ToLower().Equals(".jpeg") || extension.ToLower().Equals(".png") || extension.ToLower().Equals(".jfif"))
                        {
                            byte[] imgEdit= ImageToByteArray(starship.imageFile);
                            starship.Image = imgEdit;
                            //_context.Update(starship.image);
                        }
                    }
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

        //Convert image to byte array
        public byte[]? ImageToByteArray(IFormFile? imgInput)
        {
            byte[] byteArray = null;
            using (var memoryStream = new MemoryStream())
            {
                //Copy the image to target memory stream:
                imgInput.CopyToAsync(memoryStream);
                //Input validation - limit upload size to 2 MB: 
                if (memoryStream.Length < 2097152)
                {
                    byteArray = memoryStream.ToArray();
                    return byteArray;
                }
                else
                {
                    ModelState.AddModelError("ImageSize", "The image file is too large.");
                    return byteArray;
                }
            }
        }

        //Convert byte array to image
        public ActionResult byteToImg(int Id)
        {
            Starship record = _context.Starship.Find(Id);
            //If there is an image in the record, display it: 
            if(record.Image != null)
            {
                byte[] byteArray = record.Image;
                return File(byteArray, "image/jpeg");
            }
            //If no image has been set, use a default path:
            else
            {
                return File("~/image/defaultship.jpg", "image/jpeg");
            }
        }
    }
}
