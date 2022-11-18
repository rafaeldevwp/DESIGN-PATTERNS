using BUILDER.Componentes;

namespace BUILDER.Produtos
{
    public class Veiculo
    {
        private TipoVeiculo tipoveiculo;
        private int acentos;
        private Motor motor;
        private Transmissao transmissao;

        public TipoVeiculo TipoVeiculo {
            get => tipoveiculo;
            set => tipoveiculo = value;
        }

        public int Acentos {
            get => acentos;
            set => acentos = value;
        }

        public Motor Motor {
            get => motor;
            set => motor = value;
        }           

        public Transmissao Transmissao
        {
            get => transmissao;
            set => transmissao = value;
        }
    }
}
