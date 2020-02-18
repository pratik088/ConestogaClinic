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
    //Medication Type Controller
    public class PSMedicationTypeController : Controller
    {
        private readonly PatientsContext _context;

        public PSMedicationTypeController(PatientsContext context)
        {
            _context = context;
        }

        // GET: PSMedicationType
        // Index method retrieving the list of data and returning them to view
        public async Task<IActionResult> Index()
        {
            ViewBag.MedicationTypeName = "";

            if (TempData.ContainsKey("MedicationError"))
            {
                string MedicationErrorMsg = TempData["MedicationError"].ToString();
                if (!String.IsNullOrEmpty(MedicationErrorMsg))
                {
                    ViewBag.MedicationErrorMsg = MedicationErrorMsg;
                }
            }
                return View(await _context.MedicationType.ToListAsync());
        }

        // GET: PSMedicationType/Details/5
        // Details method showing detail data of the selected item
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicationType = await _context.MedicationType
                .FirstOrDefaultAsync(m => m.MedicationTypeId == id);
            if (medicationType == null)
            {
                return NotFound();
            }

            return View(medicationType);
        }

        // GET: PSMedicationType/Create
        // Create method returning create view for http post
        public IActionResult Create()
        {
            return View();
        }

        // POST: PSMedicationType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        // create method used to create new MedicationType
        public async Task<IActionResult> Create([Bind("MedicationTypeId,Name")] MedicationType medicationType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicationType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medicationType);
        }

        // GET: PSMedicationType/Edit/5
        // This method is searching selected id before sending it to httpPost
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicationType = await _context.MedicationType.FindAsync(id);
            if (medicationType == null)
            {
                return NotFound();
            }
            return View(medicationType);
        }

        // POST: PSMedicationType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //POST Edit method to edit selected item's parameters.
        public async Task<IActionResult> Edit(int id, [Bind("MedicationTypeId,Name")] MedicationType medicationType)
        {
            if (id != medicationType.MedicationTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicationType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicationTypeExists(medicationType.MedicationTypeId))
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
            return View(medicationType);
        }

        // GET: PSMedicationType/Delete/5
        // Get method returning the view of the Medication Type that needs to be deleted.
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicationType = await _context.MedicationType
                .FirstOrDefaultAsync(m => m.MedicationTypeId == id);
            if (medicationType == null)
            {
                return NotFound();
            }

            return View(medicationType);
        }

        // POST: PSMedicationType/Delete/5
        // This httppost method will delete the data fetched from DeleteConfirmed method.
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        // Overloaded delete method for http POST 
        // Fetching id to delete
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medicationType = await _context.MedicationType.FindAsync(id);
            _context.MedicationType.Remove(medicationType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicationTypeExists(int id)
        {
            return _context.MedicationType.Any(e => e.MedicationTypeId == id);
        }
    }
}
