using BUILDER.Componentes;
using BUILDER.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUILDER.Builders
{
    public interface IConstrutor
    {
        void Reiniciar();
        Veiculo ObterVeiculo();
        void SetAcentos(int acentos);
        void SetMotor(Motor motor);
        void SetTransmissao(Transmissao transmissao);
        void SetTipoVeiculo(TipoVeiculo tipoVeiculo);

    }
}
