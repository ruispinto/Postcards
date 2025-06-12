using PostcardsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostcardsWeb.DataAccess.Repository.IRepository
{
    public interface ICardRepository : IRepository<Card>
    {
        IEnumerable<Card> GetAllCatalog(string? searchItems = null, string? sortBy = "Number", string? sortDirection = "Asc", int pageNumber = 1, int pageSize = 100);

        void Update(Card obj);

        int CountAll(string? searchItems);
    }
}
