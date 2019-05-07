namespace Bet.Logica
{
    using System;
    using System.Linq;
    using Bet.Conexion;

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
