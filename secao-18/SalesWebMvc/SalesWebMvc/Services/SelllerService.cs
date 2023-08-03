using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class SelllerService
    {
        private readonly SalesWebMvcContext _context;

        public SelllerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll() 
        {
            return _context.Seller.ToList();
        }
    }
}
