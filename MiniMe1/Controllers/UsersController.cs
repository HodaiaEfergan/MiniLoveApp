//using System;
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
    public class UsersController : Controller
    {
        private readonly MiniMe1Context _context;

        public UsersController(MiniMe1Context context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("manag") == null)
            {
                return RedirectToAction(nameof(LogIn));
            }
            return View(await _context.Users.ToListAsync());
        }
        public async Task<IActionResult> LogUot()
        {
            HttpContext.Session.Remove("user");
            HttpContext.Session.Remove("manag");
            

            return RedirectToAction(nameof(LogIn));
           
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (users == null)
            {
                return NotFound();
            }

            return View(users);
        }

        // GET: Users/Create
        
        public IActionResult answer()
        {
            return View();
        }
        

        public IActionResult Create()
        {
            return View();
        }
        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Manag,Name,Mail,City,Phone,password")] Users users)
        {
            if (ModelState.IsValid)
            {
                _context.Add(users);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(users);
        }
        public IActionResult LogIn()
        {
            return View();
        }
        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn([Bind("Id,Manag,Name,Mail,City,Phone,password")] Users users)
        {
            var p = from u in _context.Users
                    where users.Name == u.Name &&
                          users.password == u.password  
                    select u;
            var m= from i in _context.Users
                   where users.Name == i.Name &&
                         users.password == i.password &&
                         i.Manag == "מנהל"
                   select i;
            if (m.Count() > 0)
            {
                HttpContext.Session.SetString("user", m.First().Name);
                HttpContext.Session.SetString("manag", m.First().Name);
                return RedirectToAction(nameof(Index));
                
            }
            else  
            {    if (p.Count() > 0) 
                {
                    HttpContext.Session.SetString("user", p.First().Name);
                    return RedirectToAction("Index","Home");
                    
                }

                else
                {
                    ViewData["Error"] = "משתמש לא קיים!";
                }
            }
            return View(users);
        }
        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users.FindAsync(id);
            if (users == null)
            {
                return NotFound();
            }
            return View(users);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Manag,Name,Mail,City,Phone,password")] Users users)
        {
            if (id != users.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(users);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsersExists(users.Id))
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
            return View(users);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (users == null)
            {
                return NotFound();
            }

            return View(users);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var users = await _context.Users.FindAsync(id);
            _context.Users.Remove(users);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsersExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
