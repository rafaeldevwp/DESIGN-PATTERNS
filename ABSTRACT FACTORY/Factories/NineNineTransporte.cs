using ABSTRACT_FACTORY.Veiculos;
using System;

namespace ABSTRACT_FACTORY.Factories
{
    public class NineNineTransporte : ITransporteFactory
    {
        public ITransporteAereo CriarTransporteAereo()
        {
            return new Helicoptero();
        }

       public  ITransporteTerrestre CriarTransporteTerrestre()
        {
            return new Moto();
        }
    }
}
