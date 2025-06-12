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
    public class SerieRepository : Repository<Serie>, ISerieRepository
    {
        private ApplicationDbContext _db;

        public SerieRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Serie obj)
        {
            var objFromDb = _db.Series.FirstOrDefault(u => u.SerieId == obj.SerieId);
            if (objFromDb != null)
            {
                objFromDb.SerieNumber = obj.SerieNumber;
                objFromDb.NameOrig = obj.NameOrig;
                objFromDb.NamePt = obj.NamePt;
                objFromDb.IsScan = obj.IsScan;
                objFromDb.SerieDate = obj.SerieDate;
                objFromDb.PrintYear = obj.PrintYear;
                objFromDb.PhotoYear = obj.PhotoYear;
                objFromDb.IsMultiview = obj.IsMultiview;
                objFromDb.TotalPhotos = obj.TotalPhotos;
                objFromDb.IsIdentical = obj.IsIdentical;
                objFromDb.Barcode = obj.Barcode;
                objFromDb.HasFrame = obj.HasFrame;
                objFromDb.FrontText = obj.FrontText;
                objFromDb.FrontColor = obj.FrontColor;
                objFromDb.BackText = obj.BackText;
                objFromDb.BackColor = obj.BackColor;
                objFromDb.WebPage = obj.WebPage;
                objFromDb.ShwFrtImg = obj.ShwFrtImg;
                objFromDb.ShwBckImg = obj.ShwBckImg;
                objFromDb.SerieDesc = obj.SerieDesc;
                objFromDb.SerieTags = obj.SerieTags;
                objFromDb.SerieCardId = obj.SerieCardId;
                objFromDb.OriginCountryId = obj.OriginCountryId;
                objFromDb.SerieColorId = obj.SerieColorId;
                objFromDb.FrontOrientId = obj.FrontOrientId;
                objFromDb.BackOrientId = obj.BackOrientId;
                if (obj.FrontImg != null)
                {
                    objFromDb.FrontImg = obj.FrontImg;
                }
                if (obj.BackImg != null)
                {
                    objFromDb.BackImg = obj.BackImg;
                }
            }
        }
    }
}

