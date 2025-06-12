using PostcardsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostcardsWeb.DataAccess.Repository.IRepository
{
    public interface ISerieRepository : IRepository<Serie>
    {
        void Update(Serie obj);
    }
}
