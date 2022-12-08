using FACTORY.Produtos.Componentes;
using FACTORY.Produtos.Interfaces;
using System;

namespace FACTORY.Produtos
{
    public class Veiculo : IVeiculo
    {
        public Veiculo()
        {
            this.CriarVeiculo();
        }
        public void CriarVeiculo()
        {
            Console.WriteLine("Veiculo criado");
        }
    }
}
