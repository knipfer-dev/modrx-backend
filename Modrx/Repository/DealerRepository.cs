using System;
using System.Linq;
using Modrx.Repository.Interface;
using Modrx.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

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

        public List<SubaruDealer> SearchDealers(string keyword)
        {
            var result = _context.SubaruDealers
                .FromSqlRaw(
                    "SELECT * from \"SubaruDealers\"" +
                    " where to_tsvector(\"Name\" || ' ' || \"Location\") " +
                    "@@ to_tsquery('" + keyword + ":*')")
                .ToList();

            return result;
        }
    }
}