using DESIGN_PATTERNS___CRIACIONAL.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN_PATTERNS___CRIACIONAL.Factories
{
    public abstract class Transporte
    {
        public void IniciarTransporte()
        {
            IVeiculo veiculo = CriarTransporte();
            veiculo.IniciarTrajeto();
        }

        protected abstract IVeiculo CriarTransporte();

    }
}
