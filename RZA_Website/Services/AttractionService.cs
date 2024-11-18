using Microsoft.EntityFrameworkCore;
using RZA_Website.Models;
namespace RZA_Website.Services
{
    public class AttractionService
    {
        private readonly TlS2303064Rza2Context _context;
        public AttractionService(TlS2303064Rza2Context context)
        {
            _context = context;
        }   
        public async Task<List<Attraction>> GetAttractionsAsync()
        {
            return await _context.Attractions.ToListAsync();
        }
    }
}
