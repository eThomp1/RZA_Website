using RZA_Website.Models;
using Microsoft.EntityFrameworkCore;
namespace RZA_Website.Services
{
    public class CustomerService
    {
        private readonly TlS2303064Rza2Context _context;
        public CustomerService(TlS2303064Rza2Context context)
        {
            _context = context;
        }
    }
}