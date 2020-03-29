using System.Collections.Generic;
using Modrx.Models;

namespace Modrx.Repository.Interface
{
    public interface IDealerRepository
    {
        List<SubaruDealer> GetAllDealers();
        List<SubaruDealer> SearchDealers(string keyword);
    }
}