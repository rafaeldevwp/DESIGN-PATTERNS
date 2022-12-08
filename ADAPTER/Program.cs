
using ADAPTER.Enumeradores;
using System;


namespace ADAPTER
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            var entrada = Console.ReadLine();
            
            cliente.ObterTipoPagamento((eTipoPagamento)Enum.Parse(typeof(eTipoPagamento), entrada));
            Console.ReadLine();
        }
    }
}
