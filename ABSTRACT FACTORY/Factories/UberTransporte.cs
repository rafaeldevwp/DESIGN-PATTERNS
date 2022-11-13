using ABSTRACT_FACTORY.Veiculos;

namespace ABSTRACT_FACTORY.Factories
{
    public class UberTransporte : ITransporteFactory
    {
        public ITransporteAereo CriarTransporteAereo()
        {
            return new Aviao();
        }

        public ITransporteTerrestre CriarTransporteTerrestre()
        {
            return new Carro();
        }
    }
}
