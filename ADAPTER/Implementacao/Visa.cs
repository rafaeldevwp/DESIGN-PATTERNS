using ADAPTER.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAPTER.Implementacao
{
    public class Visa : CartaoCredito
    {
        public Visa()
        {
            this.CobrarFatura();
        }

        public override void CobrarFatura()
        {
            Console.WriteLine("Cobranca Visa");
        }
    }
}
