using PostcardsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostcardsWeb.DataAccess.Repository.IRepository
{
    public interface IColorationRepository : IRepository<Coloration>
    {
        void Update(Coloration obj);
    }
}
