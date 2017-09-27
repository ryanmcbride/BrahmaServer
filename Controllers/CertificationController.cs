using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BrahmaServer.Models;
using Newtonsoft.Json;

namespace BrahmaServer.Controllers
{
    public class CertificationController : Controller
    {
        private readonly DBContext _context;

        public CertificationController(DBContext context)
        {
            _context = context;
        }

        // GET: Certification
        public async Task<IActionResult> Index()
        {
            return View(await _context.Certification.ToListAsync());
        }

        // GET: Certification/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certification = await _context.Certification
                .SingleOrDefaultAsync(m => m.ID == id);
            if (certification == null)
            {
                return NotFound();
            }

            return View(certification);
        }

        // GET: Certification/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Certification/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Category,ExpirationDate,Image,Description,Employee")] Certification certification)
        {
            if (ModelState.IsValid)
            {
                _context.Add(certification);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(certification);
        }

        // GET: Certification/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certification = await _context.Certification.SingleOrDefaultAsync(m => m.ID == id);
            if (certification == null)
            {
                return NotFound();
            }
            return View(certification);
        }

        // POST: Certification/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Category,ExpirationDate,Image,Description,Employee")] Certification certification)
        {
            if (id != certification.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(certification);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CertificationExists(certification.ID))
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
            return View(certification);
        }

        // GET: Certification/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certification = await _context.Certification
                .SingleOrDefaultAsync(m => m.ID == id);
            if (certification == null)
            {
                return NotFound();
            }

            return View(certification);
        }

        // POST: Certification/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var certification = await _context.Certification.SingleOrDefaultAsync(m => m.ID == id);
            _context.Certification.Remove(certification);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CertificationExists(int id)
        {
            return _context.Certification.Any(e => e.ID == id);
        }

        public async Task<string> Json(int? id) {
            if (id == null){
                var models = await _context.Certification.ToListAsync();
                if (models == null){
                    return "{}";
                }
                return JsonConvert.SerializeObject(models);
            }
            var model = await _context.Certification.SingleOrDefaultAsync(m => m.ID == id);
            if (model == null){
                return "{}";
            }
            return JsonConvert.SerializeObject(model);
        }
    }
}
