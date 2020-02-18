using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PSPatients.Models;

namespace PSPatients.Controllers
{
    // Country controller
    public class PSCountryController : Controller
    {
        private readonly PatientsContext _context;

        public PSCountryController(PatientsContext context)
        {
            _context = context;
        }

        // GET: PSCountry
        // Method for displaying the list of countries
        public async Task<IActionResult> Index()
        {
            return View(await _context.Country.ToListAsync());
        }

        // GET: PSCountry/Details/5
        // This method shows detail view of the item when you click on it from the list
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var country = await _context.Country
                .FirstOrDefaultAsync(m => m.CountryCode == id);
            if (country == null)
            {
                return NotFound();
            }

            return View(country);
        }

        // GET: PSCountry/Create
        // this method will return PSCountry/Create view for post method
        public IActionResult Create()
        {
            return View();
        }

        // POST: PSCountry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        // This method will bind all data from Country model and then add it to the database when click on submit
        //and then will redirect to the index page of its respective controller
        public async Task<IActionResult> Create([Bind("CountryCode,Name,PostalPattern,PhonePattern,FederalSalesTax")] Country country)
        {
            if (ModelState.IsValid)
            {
                _context.Add(country);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(country);
        }

        // GET: PSCountry/Edit/5
        // This method will search for selected id and will return not found if not present
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var country = await _context.Country.FindAsync(id);
            if (country == null)
            {
                return NotFound();
            }
            return View(country);
        }

        // POST: PSCountry/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        // This method is used to edit the data of the item
        // it will fetch all the data of selected item and then the user can edit it.
        public async Task<IActionResult> Edit(string id, [Bind("CountryCode,Name,PostalPattern,PhonePattern,FederalSalesTax")] Country country)
        {
            if (id != country.CountryCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(country);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CountryExists(country.CountryCode))
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
            return View(country);
        }

        // GET: PSCountry/Delete/5
        // This method will return the view of country where you can submit the (httppost) for the deletion
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var country = await _context.Country
                .FirstOrDefaultAsync(m => m.CountryCode == id);
            if (country == null)
            {
                return NotFound();
            }

            return View(country);
        }

        // POST: PSCountry/Delete/5
        // This httppost method will delete the data fetched from DeleteConfirmed method.
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        // Overloaded delete method for http POST 
        // Fetching id to delete
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var country = await _context.Country.FindAsync(id);
            _context.Country.Remove(country);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // This is flag to decide if the county exits or not
        private bool CountryExists(string id)
        {
            return _context.Country.Any(e => e.CountryCode == id);
        }
    }
}
