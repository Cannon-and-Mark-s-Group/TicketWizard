using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketWizard.Data;
using TicketWizard.Models;

namespace TicketWizard.Controllers
{
    public class TicketController : Controller
    {
        private readonly TicketWizardContext _context;

        public TicketController(TicketWizardContext context)
        {
            _context = context;
        }

        // GET: Ticket
        public async Task<IActionResult> Index()
        {
            try
            {
                var test = _context.Techs.ToList();
            }
            catch (Exception ex)
            {

            }
            return View(await _context.RequestTickets.ToListAsync());
        }

        // GET: Ticket/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RequestTickets == null)
            {
                return NotFound();
            }

            var ticket = await _context.RequestTickets
                .FirstOrDefaultAsync(m => m.TicketId == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // GET: Ticket/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ticket/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TicketId,TechId,Description,CreatedDate,Location,Priority,EndDate,Notes")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ticket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ticket);
        }

        // GET: Ticket/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RequestTickets == null)
            {
                return NotFound();
            }

            var ticket = await _context.RequestTickets.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }
            return View(ticket);
        }

        // POST: Ticket/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TicketId,TechId,Description,CreatedDate,Location,Priority,EndDate,Notes")] Ticket ticket)
        {
            if (id != ticket.TicketId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ticket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketExists(ticket.TicketId))
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
            return View(ticket);
        }

        // GET: Ticket/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RequestTickets == null)
            {
                return NotFound();
            }

            var ticket = await _context.RequestTickets
                .FirstOrDefaultAsync(m => m.TicketId == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: Ticket/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RequestTickets == null)
            {
                return Problem("Entity set 'TicketAppContext.Ticket'  is null.");
            }
            var ticket = await _context.RequestTickets.FindAsync(id);
            if (ticket != null)
            {
                _context.RequestTickets.Remove(ticket);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(int id)
        {
            return _context.RequestTickets.Any(e => e.TicketId == id);
        }
    }
}
