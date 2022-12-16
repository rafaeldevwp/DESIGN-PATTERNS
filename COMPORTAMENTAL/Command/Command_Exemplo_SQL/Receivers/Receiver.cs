using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace COMPORTAMENTAL.Command.Command_Exemplo_SQL.Receivers
{
    public class Receiver
    {
        public void Insert(string query)
        {
            ExecutarQuery(query);
        }

        public void Delete(string query)
        {
            ExecutarQuery(query);
        }

        public void Update(string query)
        {
            ExecutarQuery(query);
        }

        private static void ExecutarQuery(string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("EXECUTANDO.....");
            Thread.Sleep(3000);
            Console.WriteLine("FINALIZADO.....");
        }

    }
}
