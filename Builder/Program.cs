using BUILDER.Builders;
using BUILDER.Diretores;
using BUILDER.Produtos;
using System;
using System.Reflection.Emit;

namespace BUILDER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstrutorVeiculos construtor = new ConstrutorVeiculos();
            Diretor diretor = new Diretor(construtor);

            diretor.ConstrutorSedan();
            Veiculo sedan = construtor.ObterVeiculo();

            Console.WriteLine($"Criado um veiculo do tipo {sedan.TipoVeiculo}");
         

            diretor.ConstrutorCaminhao();
  
            Veiculo caminhao = construtor.ObterVeiculo();
            Console.WriteLine($"Criado um veiculo do tipo {caminhao.TipoVeiculo}");
            Console.ReadLine();

        }
    }
}
