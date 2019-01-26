using Injection_de_dépendance.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injection_de_dépendance.Metier
{
    class ImplMetier : IMetier
    {
        private IDao _dao;
        public ImplMetier(IDao dao)
        {
            this._dao = dao;
        }
        public int Calcul()
        {
            return _dao.Calcul() * 3;
        }
    }
}
