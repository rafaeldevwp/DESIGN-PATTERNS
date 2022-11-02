using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DESIGN_PATTERNS___CRIACIONAL.Veiculos;

namespace DESIGN_PATTERNS___CRIACIONAL.Factories
{
    internal class CarroTransporte : Transporte
    {
        protected override IVeiculo CriarTransporte()
        {
            return new Carro();
        }
    }
}
