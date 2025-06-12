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
    public class BorderRepository : Repository<Border>, IBorderRepository
    {
        private ApplicationDbContext _db;

        public BorderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Border obj)
        {
            _db.Borders.Update(obj);
        }
    }
}
