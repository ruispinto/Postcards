using PostcardsWeb.DataAccess.Data;
using PostcardsWeb.DataAccess.Repository.IRepository;
using PostcardsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostcardsWeb.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;

        public IBorderRepository Border { get; private set; }
        public IBrandRepository Brand { get; private set; }
        public ICardRepository Card { get; private set; }
        public IColorationRepository Coloration { get; private set; }
        public ICountryRepository Country { get; private set; }
        public IMaterialRepository Material { get; private set; }
        public IOrientationRepository Orientation { get; private set; }
        public ISerieRepository Serie { get; private set; }
        public IShapeRepository Shape { get; private set; }
        public ISizeRepository Size { get; private set; }
        public ICardIdentRepository CardIdent { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Border = new BorderRepository(_db);
            Brand = new BrandRepository(_db);
            Card = new CardRepository(_db);
            Coloration = new ColorationRepository(_db);
            Material = new MaterialRepository(_db);
            Orientation = new OrientationRepository(_db);
            Serie = new SerieRepository(_db);
            Shape = new ShapeRepository(_db);
            Size = new SizeRepository(_db);
            CardIdent = new CardIdentRepository(_db);

            Country = new CountryRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
