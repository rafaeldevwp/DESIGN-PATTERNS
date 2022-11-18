using BUILDER.Builders;
using BUILDER.Componentes;

namespace BUILDER.Diretores
{
    public class Diretor
    {
        IConstrutor construtor;

        public Diretor(IConstrutor construtor)
        {
            this.construtor = construtor;
        }

        public void ConstrutorSedan()
        {
            construtor.SetTipoVeiculo(TipoVeiculo.SEDAN);
            construtor.SetMotor(new Motor(2000));
            construtor.SetAcentos(5);
            construtor.SetTransmissao(Transmissao.AUTOMATIC);
        }

        public void ConstrutorCaminhao()
        {
            construtor.SetTipoVeiculo(TipoVeiculo.TRUCK);
            construtor.SetMotor(new Motor(4000));
            construtor.SetAcentos(2);
            construtor.SetTransmissao(Transmissao.MANUAL);
        }
    }
}
