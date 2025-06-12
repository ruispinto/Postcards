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
    public class ColorationRepository : Repository<Coloration>, IColorationRepository
    {
        private ApplicationDbContext _db;

        public ColorationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Coloration obj)
        {
            _db.Colorations.Update(obj);
        }
    }
}
