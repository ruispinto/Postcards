using Microsoft.EntityFrameworkCore;
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
    public class CardRepository : Repository<Card>, ICardRepository
    {
        private ApplicationDbContext _db;

        public CardRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public int CountAll(string? searchItems)
        {
            var query = _db.Cards.AsQueryable();

            // Filtering
            if (string.IsNullOrWhiteSpace(searchItems) == false)
            {
                query = query.Where(x => x.CardNumber.Contains(searchItems) || x.CardTags.Contains(searchItems));
            }

            return query.Count();
        }

        public IEnumerable<Card> GetAllCatalog(string? searchItems, string? sortBy, string? sortDirection, int pageNumber = 1, int pageSize = 48)
        {
            var query = _db.Cards.AsQueryable();
            
            // Filtering
            if (string.IsNullOrWhiteSpace(searchItems) == false)
            {
                query = query.Where(x => x.CardNumber.Contains(searchItems) || x.CardTags.Contains(searchItems));
            }

            // Sorting
            if (string.IsNullOrWhiteSpace(sortBy) == false)
            {
                var isDesc = string.Equals(sortDirection, "Desc", StringComparison.OrdinalIgnoreCase);
                if (string.Equals(sortBy, "Number", StringComparison.OrdinalIgnoreCase))
                {
                    query = isDesc ? query.OrderByDescending(x => x.CardNumber) : query.OrderBy(x => x.CardNumber);
                }
            }


            // Pagination
            var skipResults = (pageNumber - 1) * pageSize;
            query = query.Skip(skipResults).Take(pageSize);

            return query.ToList();
        }

        public void Update(Card obj)
        {
            var objFromDb = _db.Cards.FirstOrDefault(u => u.CardId == obj.CardId);
            if (objFromDb != null)
            {
                objFromDb.CardNumber = obj.CardNumber;
                objFromDb.NameOrig = obj.NameOrig;
                objFromDb.NamePt = obj.NamePt;
                objFromDb.IsActive = obj.IsActive;
                objFromDb.IsVisible = obj.IsVisible;
                objFromDb.IsFav = obj.IsFav;
                objFromDb.IsScan = obj.IsScan;
                objFromDb.PrintYear = obj.PrintYear;
                objFromDb.PhotoYear = obj.PhotoYear;
                objFromDb.TotalPhotos = obj.TotalPhotos;
                objFromDb.IsSeries = obj.IsSeries;
                objFromDb.IsPuzzle = obj.IsPuzzle;
                objFromDb.IsIdentical = obj.IsIdentical;
                objFromDb.Barcode = obj.Barcode;
                objFromDb.HasFrame = obj.HasFrame;
                objFromDb.Dimensions = obj.Dimensions;
                objFromDb.FrontText = obj.FrontText;
                objFromDb.FrontColor = obj.FrontColor;
                objFromDb.BackText = obj.BackText;
                objFromDb.BackColor = obj.BackColor;
                objFromDb.WebPage = obj.WebPage;
                objFromDb.ShwFrtImg = obj.ShwFrtImg;
                objFromDb.ShwBckImg = obj.ShwBckImg;
                objFromDb.CardDesc = obj.CardDesc;
                objFromDb.CardTags = obj.CardTags;
                objFromDb.CardBorderId = obj.CardBorderId;
                objFromDb.CardBrandId = obj.CardBrandId;
                objFromDb.OriginCountryId = obj.OriginCountryId;
                objFromDb.PrintedCountryId = obj.PrintedCountryId;
                objFromDb.CardColorId = obj.CardColorId;
                objFromDb.CardSizeId = obj.CardSizeId;
                objFromDb.CardShapeId = obj.CardShapeId;
                objFromDb.CardMatId = obj.CardMatId;
                objFromDb.FrontOrientId = obj.FrontOrientId;
                objFromDb.BackOrientId = obj.BackOrientId;
                objFromDb.Number = obj.Number;
                objFromDb.NeedReplace = obj.NeedReplace;
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
