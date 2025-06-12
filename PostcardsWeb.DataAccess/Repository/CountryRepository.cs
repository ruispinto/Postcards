using PostcardsWeb.DataAccess.Data;
using PostcardsWeb.DataAccess.Repository.IRepository;
using PostcardsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PostcardsWeb.DataAccess.Repository
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        private ApplicationDbContext _db;

        public CountryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Country obj)
        {
            _db.Countries.Update(obj);
        }
    }
}
