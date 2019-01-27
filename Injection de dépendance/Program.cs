using Injection_de_dépendance.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Context;
using Spring.Context.Support;
using Injection_de_dépendance.Metier;

namespace Injection_de_dépendance
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IMetier dao = ctx["MyMetier"] as IMetier;
            //ImplDao1 dao1 = (ImplDao1)ctx.GetObject("MyDao");
            Console.WriteLine(dao.Calcul());
            Console.ReadKey();
        }
    }
}
