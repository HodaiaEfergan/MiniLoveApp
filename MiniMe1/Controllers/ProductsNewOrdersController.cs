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
    public class ProductsNewOrdersController : Controller
    {
        private readonly MiniMe1Context _context;

        public ProductsNewOrdersController(MiniMe1Context context)
        {
            _context = context;
        }

        // GET: ProductsNewOrders
        public async Task<IActionResult> Index()
        {
            var miniMe1Context = _context.ProductsNewOrder.Include(p => p.NewOrder).Include(p => p.Products);
            return View(await miniMe1Context.ToListAsync());
        }

        // GET: ProductsNewOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productsNewOrder = await _context.ProductsNewOrder
                .Include(p => p.NewOrder)
                .Include(p => p.Products)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (productsNewOrder == null)
            {
                return NotFound();
            }

            return View(productsNewOrder);
        }

        // GET: ProductsNewOrders/Create
        public IActionResult Create()
        {
            ViewData["NewOrderId"] = new SelectList(_context.NewOrder, "Id", "CW");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Category");
            return View();
        }

        // POST: ProductsNewOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductId,NewOrderId")] ProductsNewOrder productsNewOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productsNewOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NewOrderId"] = new SelectList(_context.NewOrder, "Id", "CW", productsNewOrder.NewOrderId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Category", productsNewOrder.ProductId);
            return View(productsNewOrder);
        }

        // GET: ProductsNewOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productsNewOrder = await _context.ProductsNewOrder.FindAsync(id);
            if (productsNewOrder == null)
            {
                return NotFound();
            }
            ViewData["NewOrderId"] = new SelectList(_context.NewOrder, "Id", "CW", productsNewOrder.NewOrderId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Category", productsNewOrder.ProductId);
            return View(productsNewOrder);
        }

        // POST: ProductsNewOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductId,NewOrderId")] ProductsNewOrder productsNewOrder)
        {
            if (id != productsNewOrder.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productsNewOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsNewOrderExists(productsNewOrder.ProductId))
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
            ViewData["NewOrderId"] = new SelectList(_context.NewOrder, "Id", "CW", productsNewOrder.NewOrderId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Category", productsNewOrder.ProductId);
            return View(productsNewOrder);
        }

        // GET: ProductsNewOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productsNewOrder = await _context.ProductsNewOrder
                .Include(p => p.NewOrder)
                .Include(p => p.Products)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (productsNewOrder == null)
            {
                return NotFound();
            }

            return View(productsNewOrder);
        }

        // POST: ProductsNewOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productsNewOrder = await _context.ProductsNewOrder.FindAsync(id);
            _context.ProductsNewOrder.Remove(productsNewOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductsNewOrderExists(int id)
        {
            return _context.ProductsNewOrder.Any(e => e.ProductId == id);
        }
    }
}
