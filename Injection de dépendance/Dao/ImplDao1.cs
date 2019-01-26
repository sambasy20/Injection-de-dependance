using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injection_de_dépendance.Dao
{
    public class ImplDao1 : IDao
    {
        public int Calcul()
        {
            return 45;
        }
    }
}
