using PostcardsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostcardsWeb.DataAccess.Repository.IRepository
{
    public interface IOrientationRepository : IRepository<Orientation>
    {
        void Update(Orientation obj);
    }
}
