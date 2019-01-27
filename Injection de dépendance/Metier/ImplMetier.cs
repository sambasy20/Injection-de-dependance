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
        public IDao _dao { get; set; }
        //public ImplMetier(IDao dao)
        //{
        //    this._dao = dao;
        //}


        public int Calcul()
        {
            return _dao.Calcul() * 3;
        }
    }
}
