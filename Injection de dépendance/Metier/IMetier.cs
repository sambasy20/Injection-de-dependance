using Injection_de_dépendance.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injection_de_dépendance.Metier
{
    interface IMetier
    {
        IDao _dao { get; set; }
        int Calcul();
    }
}
