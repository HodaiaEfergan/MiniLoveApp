using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiniMe1.Data;
using sharedAngular.Models;

namespace MiniMe1.Controllers
{
    public class PaysController : Controller
    {
        private readonly MiniMe1Context _context;

        public PaysController(MiniMe1Context context)
        {
            _context = context;
        }

        // GET: Pays
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("manag") != null)
            {
                return View(await _context.Pay.ToListAsync());
            }
            return RedirectToAction("Index", "Home");
            
        }

        // GET: Pays/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pay = await _context.Pay
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pay == null)
            {
                return NotFound();
            }

            return View(pay);
        }

        // GET: Pays/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("user") == null)
            {
                return RedirectToAction("Index", "User");
            }
            return View();
        }

        // POST: Pays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,CreditNum,ExpireMonth,ExpireYear,OwnName,IdNum,CW")] Pay pay)
        {
            if (HttpContext.Session.GetString("user") == null)
            {
                return RedirectToAction("Index", "User");
            }
            if (ModelState.IsValid)
            {
                _context.Add(pay);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pay);
        }

        // GET: Pays/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pay = await _context.Pay.FindAsync(id);
            if (pay == null)
            {
                return NotFound();
            }
            return View(pay);
        }

        // POST: Pays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,CreditNum,ExpireMonth,ExpireYear,OwnName,IdNum,CW")] Pay pay)
        {
            if (id != pay.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PayExists(pay.Id))
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
            return View(pay);
        }

        // GET: Pays/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pay = await _context.Pay
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pay == null)
            {
                return NotFound();
            }

            return View(pay);
        }

        // POST: Pays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pay = await _context.Pay.FindAsync(id);
            _context.Pay.Remove(pay);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PayExists(int id)
        {
            return _context.Pay.Any(e => e.Id == id);
        }
    }
}
