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
    public class OrientationRepository : Repository<Orientation>, IOrientationRepository
    {
        private ApplicationDbContext _db;

        public OrientationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Orientation obj)
        {
            _db.Orientations.Update(obj);
        }
    }
}
