using Microsoft.EntityFrameworkCore;
using RZA_Website.Models;

namespace RZA_Website.Services
{
   
    public class TicketService
    {
        private readonly TlS2303064Rza2Context _context;
        public TicketService(TlS2303064Rza2Context context)
        {
            _context = context;
        }
        public async Task<List<Ticket>> GetTicketsAsync()
        {
            return await _context.Tickets.ToListAsync();
        }
        public async Task AddTicketAsync(Ticket newTicket)
        {
            await _context.Tickets.AddAsync(newTicket);
            await _context.SaveChangesAsync();
        }
    }
}
