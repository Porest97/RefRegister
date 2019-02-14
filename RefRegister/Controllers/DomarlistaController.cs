using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RefRegister.Models;

namespace RefRegister.Controllers
{
    public class DomarlistaController : Controller
    {
        private readonly RefRegisterContext _context;

        public DomarlistaController(RefRegisterContext context)
        {
            _context = context;
        }

        // GET: Domarlista
        // GET: Referees
        public async Task<IActionResult> Index(String searchString)
        {
            // Query for retrieving all referees
            var domare = from d in _context.Domarlista
                           select d;
            // Query for retrieving referees that contain the searchstring
            if (!String.IsNullOrEmpty(searchString))
            {
                domare = _context.Domarlista
                    .Where(pv => pv.Email.ToLower().Contains(searchString.ToLower()) ||
                    pv.FirstName.ToLower().Contains(searchString.ToLower()) ||
                    pv.LastName.ToLower().Contains(searchString.ToLower()) ||
                    pv.StreetAddress.ToLower().Contains(searchString.ToLower()) ||
                    pv.Zipcode.ToLower().Contains(searchString.ToLower()) ||
                    pv.County.ToLower().Contains(searchString.ToLower()) ||
                    pv.RefNumber.ToLower().Contains(searchString.ToLower()) ||
                    pv.Club.ToLower().Contains(searchString.ToLower()) ||
                    pv.Category.ToLower().Contains(searchString.ToLower()) ||
                    pv.CategoryType.ToLower().Contains(searchString.ToLower()) ||
                    pv.Distrikt.ToLower().Contains(searchString.ToLower()) ||
                    pv.BirthDate.ToLower().Contains(searchString.ToLower()) ||
                    pv.RefType.ToLower().Contains(searchString.ToLower())
                    );

            }

            return View(await domare.ToListAsync());
        }
        public async Task<IActionResult> SearchView(String searchString)
        {
            // Query for retrieving all referees
            var domare = from d in _context.Domarlista
                         select d;
            // Query for retrieving referees that contain the searchstring
            if (!String.IsNullOrEmpty(searchString))
            {
                domare = _context.Domarlista
                    .Where(pv => pv.Email.ToLower().Contains(searchString.ToLower()) ||
                    pv.FirstName.ToLower().Contains(searchString.ToLower()) ||
                    pv.LastName.ToLower().Contains(searchString.ToLower()) ||
                    pv.StreetAddress.ToLower().Contains(searchString.ToLower()) ||
                    pv.Zipcode.ToLower().Contains(searchString.ToLower()) ||
                    pv.County.ToLower().Contains(searchString.ToLower()) ||
                    pv.Club.ToLower().Contains(searchString.ToLower()) ||
                    pv.Category.ToLower().Contains(searchString.ToLower()) ||
                    pv.CategoryType.ToLower().Contains(searchString.ToLower()) ||
                    pv.Distrikt.ToLower().Contains(searchString.ToLower()) ||
                    pv.BirthDate.ToLower().Contains(searchString.ToLower()) ||
                    pv.RefType.ToLower().Contains(searchString.ToLower())
                    );

            }

            return View(await domare.ToListAsync());
        }


        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Domarlista.ToListAsync());
        //}

        // GET: Domarlista/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var domarlista = await _context.Domarlista
                .FirstOrDefaultAsync(m => m.Id == id);
            if (domarlista == null)
            {
                return NotFound();
            }

            return View(domarlista);
        }

        // GET: Domarlista/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Domarlista/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,RefNumber,BirthDate,RefType,Category,CategoryType,Distrikt,Club,StreetAddress,Zipcode,County,Phone1,Phone2,Email,Registred,Created,Payed")] Domarlista domarlista)
        {
            if (ModelState.IsValid)
            {
                _context.Add(domarlista);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(domarlista);
        }

        // GET: Domarlista/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var domarlista = await _context.Domarlista.FindAsync(id);
            if (domarlista == null)
            {
                return NotFound();
            }
            return View(domarlista);
        }

        // POST: Domarlista/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,RefNumber,BirthDate,RefType,Category,CategoryType,Distrikt,Club,StreetAddress,Zipcode,County,Phone1,Phone2,Email,Registred,Created,Payed")] Domarlista domarlista)
        {
            if (id != domarlista.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(domarlista);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DomarlistaExists(domarlista.Id))
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
            return View(domarlista);
        }

        // GET: Domarlista/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var domarlista = await _context.Domarlista
                .FirstOrDefaultAsync(m => m.Id == id);
            if (domarlista == null)
            {
                return NotFound();
            }

            return View(domarlista);
        }

        // POST: Domarlista/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var domarlista = await _context.Domarlista.FindAsync(id);
            _context.Domarlista.Remove(domarlista);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DomarlistaExists(int id)
        {
            return _context.Domarlista.Any(e => e.Id == id);
        }
    }
}
