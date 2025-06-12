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
    public class SizeRepository : Repository<Size>, ISizeRepository
    {
        private ApplicationDbContext _db;

        public SizeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Size obj)
        {
            _db.Sizes.Update(obj);
        }
    }
}
