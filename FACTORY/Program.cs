using FACTORY.Factory;
using FACTORY.Produtos.Componentes;
using FACTORY.Produtos.Enum;
using System;

namespace FACTORY
{
    public class Program
    {
        static void Main(string[] args)
        {
            var moto = new FabricaVeiculos();

            moto.SetTransmissao(new Transmissao { Tipo = eTransmissao.Manual});
            moto.SetPneus(new Pneus { Marca = "Michellin"});
            moto.SetAssentos(new Assentos { Quantidade = 2});
            moto.SetMotor(new Motor { Potencia = 3000});
            moto.SetCor(new Cor { Tom = "Amarelo"});

            Console.WriteLine(moto.ToString());
            
        }
    }
}
