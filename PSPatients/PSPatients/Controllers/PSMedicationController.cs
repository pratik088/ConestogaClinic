using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PSPatients.Models;

namespace PSPatients.Controllers
{
    public class PSMedicationController : Controller
    {
        private readonly PatientsContext _context;
        // session variable
        const string medicationTypeId = "medicationTypeId";
        const string medicationTypeName = "MedicationTypeName";
        // added support for session
        string MedicationTypeName = "";
        public PSMedicationController(PatientsContext context)
        {
            _context = context;
           
        }

        // GET: PSMedication
        public async Task<IActionResult> Index(int id)
        {
          
           
            if (id <= 0)
            {
                if (String.IsNullOrEmpty(HttpContext.Session.GetString(medicationTypeId)))
                {
                    TempData["MedicationError"] = "Please Select Medication Type from the list.";
                    return RedirectToAction("Index", "PSMedicationType");
                }
                else
                {
                    id = Convert.ToInt32(HttpContext.Session.GetString(medicationTypeId));
                    MedicationTypeName = HttpContext.Session.GetString(medicationTypeName);
                }
            }
            else
            {
                var MedicationTypeDetail = _context.MedicationType.Where(m => m.MedicationTypeId == id).FirstOrDefault();
                MedicationTypeName = MedicationTypeDetail.Name.ToString();
                HttpContext.Session.SetString(medicationTypeId, id.ToString());
                HttpContext.Session.SetString(medicationTypeName, MedicationTypeName.ToString());
                MedicationTypeName = MedicationTypeDetail.Name.ToString();
            }

            var patientsContext = _context.Medication.Include(m => m.ConcentrationCodeNavigation).Include(m => m.DispensingCodeNavigation).Include(m => m.MedicationType).
                                    Where(m => m.MedicationTypeId == id).OrderBy(m => m.Name).ThenBy(n => n.Concentration);

            MedicationTypeName = HttpContext.Session.GetString(medicationTypeName);
            ViewBag.MedicationTypeName = MedicationTypeName;

            return View(await patientsContext.ToListAsync());
        }

        // GET: PSMedication/Details/5
        public async Task<IActionResult> Details(string id)
        {
            MedicationTypeName = HttpContext.Session.GetString(medicationTypeName);
            ViewBag.MedicationTypeName = MedicationTypeName;

            if (id == null)
            {
                return NotFound();
            }

            var medication = await _context.Medication
                .Include(m => m.ConcentrationCodeNavigation)
                .Include(m => m.DispensingCodeNavigation)
                .Include(m => m.MedicationType)
                .FirstOrDefaultAsync(m => m.Din == id);
            if (medication == null)
            {
                return NotFound();
            }

            return View(medication);
        }

        // GET: PSMedication/Create
        public IActionResult Create()
        {
            MedicationTypeName = HttpContext.Session.GetString(medicationTypeName);
            ViewBag.MedicationTypeName = MedicationTypeName;


            if (TempData.ContainsKey("MedicationexistError"))
            {
                string MedicationexistError = TempData["MedicationexistError"].ToString();
                if (!String.IsNullOrEmpty(MedicationexistError))
                {
                    ViewBag.MedicationexistError = MedicationexistError;
                }
            }
            ViewBag.MedicationTypeId = Convert.ToInt32(HttpContext.Session.GetString(medicationTypeId));
            // Order by Concentration Unit
            ViewData["ConcentrationCode"] = new SelectList(_context.ConcentrationUnit.OrderBy(m=>m.ConcentrationCode), "ConcentrationCode", "ConcentrationCode");
            // Order by Dispensing Unit
            ViewData["DispensingCode"] = new SelectList(_context.DispensingUnit.OrderBy(m => m.DispensingCode), "DispensingCode", "DispensingCode");
           // ViewData["MedicationTypeId"] = new SelectList(_context.MedicationType, "MedicationTypeId", "Name");
            return View();
        }

        // POST: PSMedication/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Din,Name,Image,MedicationTypeId,DispensingCode,Concentration,ConcentrationCode")] Medication medication)
        {
            if (ModelState.IsValid)
            {
                if(MedicationExists(medication.Din)==false)
                {
                    _context.Add(medication);
                    await _context.SaveChangesAsync();
                    HttpContext.Session.SetString(medicationTypeId, medication.MedicationTypeId.ToString());
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["MedicationexistError"] = "Medication Already exist";
                    return RedirectToAction("Create", "PSMedication");
                }
             
            }
            // Order by Concentration Unit
            ViewData["ConcentrationCode"] = new SelectList(_context.ConcentrationUnit.OrderBy(m => m.ConcentrationCode), "ConcentrationCode", "ConcentrationCode");
            // Order by Dispensing Unit
            ViewData["DispensingCode"] = new SelectList(_context.DispensingUnit.OrderBy(m => m.DispensingCode), "DispensingCode", "DispensingCode");
            return View(medication);
        }

        // GET: PSMedication/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            MedicationTypeName = HttpContext.Session.GetString(medicationTypeName);
            ViewBag.MedicationTypeName = MedicationTypeName;

            @ViewBag.MedicationTypeId = Convert.ToInt32(HttpContext.Session.GetString(medicationTypeId));
            if (id == null)
            {
                return NotFound();
            }

            var medication = await _context.Medication.FindAsync(id);
            if (medication == null)
            {
                return NotFound();
            }
            // Order by Concentration Unit
            ViewData["ConcentrationCode"] = new SelectList(_context.ConcentrationUnit.OrderBy(m => m.ConcentrationCode), "ConcentrationCode", "ConcentrationCode");
            // Order by Dispensing Unit
            ViewData["DispensingCode"] = new SelectList(_context.DispensingUnit.OrderBy(m => m.DispensingCode), "DispensingCode", "DispensingCode");
            
            return View(medication);
        }

        // POST: PSMedication/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Din,Name,Image,MedicationTypeId,DispensingCode,Concentration,ConcentrationCode")] Medication medication)
        {
            if (id != medication.Din)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medication);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicationExists(medication.Din))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                HttpContext.Session.SetString(medicationTypeId, medication.MedicationTypeId.ToString()); 
                return RedirectToAction(nameof(Index));

            }
            // Order by Concentration Unit
            ViewData["ConcentrationCode"] = new SelectList(_context.ConcentrationUnit.OrderBy(m => m.ConcentrationCode), "ConcentrationCode", "ConcentrationCode");
            // Order by Dispensing Unit
            ViewData["DispensingCode"] = new SelectList(_context.DispensingUnit.OrderBy(m => m.DispensingCode), "DispensingCode", "DispensingCode");
            ViewData["MedicationTypeId"] = new SelectList(_context.MedicationType, "MedicationTypeId", "Name", medication.MedicationTypeId);
            return View(medication);
        }

        // GET: PSMedication/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            MedicationTypeName = HttpContext.Session.GetString(medicationTypeName);
            ViewBag.MedicationTypeName = MedicationTypeName;
            if (id == null)
            {
                return NotFound();
            }

            var medication = await _context.Medication
                .Include(m => m.ConcentrationCodeNavigation)
                .Include(m => m.DispensingCodeNavigation)
                .Include(m => m.MedicationType)
                .FirstOrDefaultAsync(m => m.Din == id);
            if (medication == null)
            {
                return NotFound();
            }

            return View(medication);
        }

        // POST: PSMedication/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var medication = await _context.Medication.FindAsync(id);
            _context.Medication.Remove(medication);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicationExists(string id)
        {
            return _context.Medication.Any(e => e.Din == id);
        }
    }
}
