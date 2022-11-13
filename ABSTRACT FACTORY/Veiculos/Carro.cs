using System;

namespace ABSTRACT_FACTORY.Veiculos
{
    public class Carro : ITransporteTerrestre
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
