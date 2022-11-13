using DESIGN_PATTERNS___CRIACIONAL.Veiculos;

namespace DESIGN_PATTERNS___CRIACIONAL.Factories
{
    internal class MotoTransporte : Transporte
    {
        protected override IVeiculo CriarTransporte()
        {
            return new Moto();
        }
    }
}
