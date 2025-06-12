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
    public class CardIdentRepository : Repository<CardIdent>, ICardIdentRepository
    {
        private ApplicationDbContext _db;

        public CardIdentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CardIdent obj)
        {
            _db.CardIdents.Update(obj);
        }
    }
}
