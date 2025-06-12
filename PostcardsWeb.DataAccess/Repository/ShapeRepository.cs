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
    public class ShapeRepository : Repository<Shape>, IShapeRepository
    {
        private ApplicationDbContext _db;

        public ShapeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Shape obj)
        {
            _db.Shapes.Update(obj);
        }
    }
}
