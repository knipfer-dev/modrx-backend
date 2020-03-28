using System.Linq;
using Modrx.Repository.Interface;
using Modrx.Models;
using System.Collections.Generic;

namespace Modrx.Repository
{
    public class DealerRepository : IDealerRepository
    {
        private readonly ApplicationContext _context;

        public DealerRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<SubaruDealer> GetAllDealers()
        {
            return _context.SubaruDealers.ToList();
        }
    }
}