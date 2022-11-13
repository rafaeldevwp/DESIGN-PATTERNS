using ABSTRACT_FACTORY.Factories;
using ABSTRACT_FACTORY.Veiculos;

namespace ABSTRACT_FACTORY
{
    public class Aplicacao
    {
        private ITransporteAereo transporteaereo;
        private ITransporteTerrestre transporteterrestre;

        public Aplicacao(ITransporteFactory transporteFactory)
        {
            transporteaereo = transporteFactory.CriarTransporteAereo();
            transporteterrestre = transporteFactory.CriarTransporteTerrestre();
        }

        public void IniciarTrajeto()
        {
            transporteaereo.IniciarTrajeto();
            transporteterrestre.IniciarTrajeto();
        }
    }
}
