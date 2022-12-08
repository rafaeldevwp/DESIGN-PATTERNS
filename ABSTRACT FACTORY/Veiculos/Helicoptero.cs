using System;

namespace ABSTRACT_FACTORY.Veiculos
{
    public class Helicoptero : ITransporteAereo
    {
        public void IniciarTrajeto()
        {
            CriarPlanoVoo();
            ObterCargar();

            Console.WriteLine("Iniciando trajeto helicoptero");
        }

        public void CriarPlanoVoo()
        {
            Console.WriteLine("Plano de Voo preparado");
        }

        public void ObterCargar()
        {
            Console.WriteLine("Passageiros embarcados");
        }
    }
}
