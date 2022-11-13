using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT_FACTORY.Veiculos
{
    public class Moto:ITransporteTerrestre
    {
        public void IniciarTrajeto()
        {
            ObterCargar();
            Console.WriteLine("Iniciando trajeto");
        }

        public void ObterCargar()
        {
            Console.WriteLine("Passageiro embarcado");
        }
    }
}
