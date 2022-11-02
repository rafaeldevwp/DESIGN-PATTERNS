using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN_PATTERNS___CRIACIONAL.Veiculos
{
    public class Carro : IVeiculo
    {
        public void IniciarTrajeto()
        {
            ObterCarga();
            Console.WriteLine("Iniciando Trajeto");
        }

        public void ObterCarga()
        {
            Console.WriteLine("Pegamos o passageiro");
        }
        
    }
}
