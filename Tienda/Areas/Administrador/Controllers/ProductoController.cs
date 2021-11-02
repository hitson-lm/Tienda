using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dominio.Models;

namespace Tienda.Areas.Administrador.Controllers
{
    [Area("Administrador")]
    public class ProductoController : Controller
    {
        private readonly tiendaContext _context;

        public ProductoController(tiendaContext context)
        {
            _context = context;
        }

        // GET: Administrador/Producto
        public async Task<IActionResult> Index()
        {
            var tiendaContext = _context.Producto.Include(p => p.Categoria).Include(p => p.Marca);
            return View(await tiendaContext.ToListAsync());
        }

        // GET: Administrador/Producto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .Include(p => p.Categoria)
                .Include(p => p.Marca)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Administrador/Producto/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "Denominacion");
            ViewData["MarcaId"] = new SelectList(_context.Marca, "Id", "Denominacion");
            return View();
        }

        // POST: Administrador/Producto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Denominacion,Descripcion,Costo,Precio,Existencias,MarcaId,CategoriaId,Estado")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "Denominacion", producto.CategoriaId);
            ViewData["MarcaId"] = new SelectList(_context.Marca, "Id", "Denominacion", producto.MarcaId);
            return View(producto);
        }

        // GET: Administrador/Producto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "Denominacion", producto.CategoriaId);
            ViewData["MarcaId"] = new SelectList(_context.Marca, "Id", "Denominacion", producto.MarcaId);
            return View(producto);
        }

        // POST: Administrador/Producto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,Denominacion,Descripcion,Costo,Precio,Existencias,MarcaId,CategoriaId,Estado")] Producto producto)
        {
            if (id != producto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.Id))
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
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "Denominacion", producto.CategoriaId);
            ViewData["MarcaId"] = new SelectList(_context.Marca, "Id", "Denominacion", producto.MarcaId);
            return View(producto);
        }

        // GET: Administrador/Producto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .Include(p => p.Categoria)
                .Include(p => p.Marca)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Administrador/Producto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Producto.FindAsync(id);
            _context.Producto.Remove(producto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
            return _context.Producto.Any(e => e.Id == id);
        }
    }
}
