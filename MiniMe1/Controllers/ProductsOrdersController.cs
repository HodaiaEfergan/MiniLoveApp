using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiniMe1.Data;
using sharedAngular.Models;

namespace MiniMe1.Controllers
{
    public class ProductsOrdersController : Controller
    {
        private readonly MiniMe1Context _context;

        public ProductsOrdersController(MiniMe1Context context)
        {
            _context = context;
        }

        // GET: ProductsOrders
        public async Task<IActionResult> Index()
        {
            var miniMe1Context = _context.ProductsOrder.Include(p => p.Order).Include(p => p.Products);
            return View(await miniMe1Context.ToListAsync());
        }

        // GET: ProductsOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productsOrder = await _context.ProductsOrder
                .Include(p => p.Order)
                .Include(p => p.Products)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (productsOrder == null)
            {
                return NotFound();
            }

            return View(productsOrder);
        }

        // GET: ProductsOrders/Create
        public IActionResult Create()
        {
            ViewData["OrdertId"] = new SelectList(_context.Order, "Id", "PaymentMethods");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Category");
            return View();
        }

        // POST: ProductsOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductId,OrdertId")] ProductsOrder productsOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productsOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrdertId"] = new SelectList(_context.Order, "Id", "PaymentMethods", productsOrder.OrdertId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Category", productsOrder.ProductId);
            return View(productsOrder);
        }

        // GET: ProductsOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productsOrder = await _context.ProductsOrder.FindAsync(id);
            if (productsOrder == null)
            {
                return NotFound();
            }
            ViewData["OrdertId"] = new SelectList(_context.Order, "Id", "PaymentMethods", productsOrder.OrdertId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Category", productsOrder.ProductId);
            return View(productsOrder);
        }

        // POST: ProductsOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductId,OrdertId")] ProductsOrder productsOrder)
        {
            if (id != productsOrder.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productsOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsOrderExists(productsOrder.ProductId))
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
            ViewData["OrdertId"] = new SelectList(_context.Order, "Id", "PaymentMethods", productsOrder.OrdertId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Category", productsOrder.ProductId);
            return View(productsOrder);
        }

        // GET: ProductsOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productsOrder = await _context.ProductsOrder
                .Include(p => p.Order)
                .Include(p => p.Products)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (productsOrder == null)
            {
                return NotFound();
            }

            return View(productsOrder);
        }

        // POST: ProductsOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productsOrder = await _context.ProductsOrder.FindAsync(id);
            _context.ProductsOrder.Remove(productsOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductsOrderExists(int id)
        {
            return _context.ProductsOrder.Any(e => e.ProductId == id);
        }
    }
}
