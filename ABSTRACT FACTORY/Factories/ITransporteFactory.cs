using ABSTRACT_FACTORY.Veiculos;

namespace ABSTRACT_FACTORY.Factories
{
     public interface ITransporteFactory
    {
        ITransporteTerrestre CriarTransporteTerrestre();
        ITransporteAereo CriarTransporteAereo();
    }
}
