using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN_PATTERNS___CRIACIONAL.Veiculos
{
    internal class Moto : IVeiculo
    {
        public void IniciarTrajeto()
        {
            ObterCarga();
            Console.WriteLine("Iniciamos o trajeto");
        }
        
        public void ObterCarga()
        {
            Console.WriteLine("Pegamos a a encomenda");
        }
    }
}
