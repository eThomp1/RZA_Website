using Microsoft.EntityFrameworkCore;
using RZA_Website.Models;

namespace RZA_Website.Services
{
    public class TicketBookingService
    {
        private readonly TlS2303064Rza2Context _context;
        public TicketBookingService(TlS2303064Rza2Context context)
        {
            _context = context;
        }
        public async Task<List<Ticketbooking>> GetTicketbookingsAsync()
        {
            return await _context.Ticketbookings.ToListAsync();
        }
        public async Task AddTicketbookingAsync(Ticketbooking newTicketbooking)
        {
            await _context.Ticketbookings.AddAsync(newTicketbooking);
            await _context.SaveChangesAsync();
        }
    }
}


