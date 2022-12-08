using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPORTAMENTAL.Chain_of_Responsibility
{
    public class SacarValor
    {
        public SacarValor(int clienteID, double valor)
        {
            ClienteID = clienteID;
            Valor = valor;
        }

        public int ClienteID { get; set; }
        public double Valor { get; set; }

    }
}
