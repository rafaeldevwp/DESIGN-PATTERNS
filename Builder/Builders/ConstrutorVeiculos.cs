using BUILDER.Componentes;
using BUILDER.Produtos;

namespace BUILDER.Builders
{
    public class ConstrutorVeiculos : IConstrutor
    {
        private Veiculo veiculo = new Veiculo();

        public Veiculo ObterVeiculo()
        {
            Veiculo result = veiculo;
            Reiniciar();
            return result;
        }

        public void Reiniciar()
        {
            veiculo = new Veiculo();
        }

        public void SetAcentos(int acentos)
        {
            veiculo.Acentos = acentos;
        }

        public void SetMotor(Motor motor)
        {
         veiculo.Motor = motor;
        }

        public void SetTipoVeiculo(TipoVeiculo tipoVeiculo)
        {
            veiculo.TipoVeiculo = tipoVeiculo;
        }

        public void SetTransmissao(Transmissao transmissao)
        {
            veiculo.Transmissao = transmissao;
        }
    }
}
