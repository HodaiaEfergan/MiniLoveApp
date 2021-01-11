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
    public class ProductsController : Controller
    {
        private readonly MiniMe1Context _context;

        public ProductsController(MiniMe1Context context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("user") == null)
            {
                //return RedirectToAction(nameof(LogIn));
            }
            return View(await _context.Products.ToListAsync());

        }

      

        public async Task<IActionResult> Girls()
        {
            var p = from Products in _context.Products
                    where Products.Category =="בנות"
                    select Products;
            return View(await p.ToListAsync());
          

        }
        public async Task<IActionResult> Boys()
        {
            var p = from Products in _context.Products
                    where Products.Category == "בנים"
                    select Products;
            return View(await p.ToListAsync());


        }
        public async Task<IActionResult> Baby()
        {
            var p = from Products in _context.Products
                    where Products.Category == "תינוקות"
                    select Products;
            return View(await p.ToListAsync());


        }
        public async Task<IActionResult> RecentGirls()
        {
            var p = from Products in _context.Products
                    where Products.Category == "בנות" && Products.Time.Year == DateTime.Now.Year && Products.Time.Month == DateTime.Now.Month - 2
                    select Products;
            return View(await p.ToListAsync());


        }
        public async Task<IActionResult> RecentBoys()
        {
            var p = from Products in _context.Products
                    where Products.Category == "בנים" && Products.Time.Year==DateTime.Now.Year && Products.Time.Month==DateTime.Now.Month-2
                    select Products;
            return View(await p.ToListAsync());

        }
        public async Task<IActionResult> RecentBaby()
        {
            var p = from Products in _context.Products
                    where Products.Category == "תינוקות" && Products.Time.Year == DateTime.Now.Year && Products.Time.Month == DateTime.Now.Month - 2
                    select Products;
            return View(await p.ToListAsync());

        }

        public async Task<IActionResult> Search()
        {
            return View(await _context.Products.ToListAsync());

        }
        [HttpPost]
        public async Task<IActionResult> Search(String Name)
        {
            var p = from Products in _context.Products
                    where  Products.Name.Contains(Name)
                    select Products;
            return View(await p.ToListAsync());
        }
        // GET: Products

      


        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("manag") != null)
            {
               return View(); 
            }
            return RedirectToAction("Index", "Home");
            
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Amount,Category,Type,Description,Price,NewPrice,Size,size2,size3,size4,size5,size6,size7,size8,size9,size10,Colors,Colors2,Colors3,Colors4,Time,NumOfSale,OnSale,Pictures,Pictures2,Pictures3,Pictures4,Pictures5")] Products products)
        {
            if (ModelState.IsValid)
            {
                _context.Add(products);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(products);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }
            return View(products);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Amount,Category,Type,Description,Price,NewPrice,Size,size2,size3,size4,size5,size6,size7,size8,size9,size10,Colors,Colors2,Colors3,Colors4,Time,NumOfSale,OnSale,Pictures,Pictures2,Pictures3,Pictures4,Pictures5")] Products products)
        {
            if (id != products.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(products);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsExists(products.Id))
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
            return View(products);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var products = await _context.Products.FindAsync(id);
            _context.Products.Remove(products);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductsExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
