using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT_FACTORY.Veiculos
{
    public interface ITransporteAereo
    {
        void CriarPlanoVoo();
        void ObterCargar();
        void IniciarTrajeto();

    }
}
