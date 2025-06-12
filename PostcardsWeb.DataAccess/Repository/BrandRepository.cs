﻿using PostcardsWeb.DataAccess.Data;
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
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        private ApplicationDbContext _db;

        public BrandRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Brand obj)
        {
            var objFromDb = _db.Brands.FirstOrDefault(u => u.BrandId == obj.BrandId);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.CompanyGroup = obj.CompanyGroup;
                objFromDb.BrandAbr = obj.BrandAbr;
                objFromDb.WebPage = obj.WebPage;
                objFromDb.BrandCountryId = obj.BrandCountryId;
                if(obj.BrandImage != null)
                {
                    objFromDb.BrandImage = obj.BrandImage;
                }
            }
        }
    }
}
