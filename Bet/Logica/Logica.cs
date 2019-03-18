using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bet.Conexion;

namespace Bet.Logica
{
    class Logica
    {
        public void Test()
        {
            var con = new NovaprimeEntities();
            var clientes = con.Clientes.Select(s => s.NombreLargo).ToList();

            foreach (var item in clientes)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
