using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT_FACTORY.Veiculos
{
    public class Aviao : ITransporteAereo
    {
        public void IniciarTrajeto()
        {
            CriarPlanoVoo();
            ObterCargar();

            Console.WriteLine("Iniciando trajeto");
        }

        public void CriarPlanoVoo()
        {
            Console.WriteLine("Plano de Voo preparado");
            Console.WriteLine("Tudo de certo uber avião");
        }

        public void ObterCargar()
        {
            Console.WriteLine("Passageiros embarcados");
        }
    }
}
