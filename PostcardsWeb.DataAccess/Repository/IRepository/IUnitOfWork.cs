using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostcardsWeb.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IBorderRepository Border { get; }
        IBrandRepository Brand { get; }
        ICardRepository Card { get; }
        IColorationRepository Coloration { get; }
        IMaterialRepository Material { get; }
        IOrientationRepository Orientation { get; }
        ISerieRepository Serie { get; }
        IShapeRepository Shape { get; }
        ISizeRepository Size { get; }
        ICardIdentRepository CardIdent { get; }


        ICountryRepository Country { get; }

        void Save();
    }
}
