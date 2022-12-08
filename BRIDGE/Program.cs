using BRIDGE.Exemplo02.Cores;
using BRIDGE.Exemplo02.Implementacao;
using System;

namespace BRIDGE
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cliente cliente = new Cliente();
            cliente.forma = new Circulo();
            cliente.forma.CorImplementacao = new Azul();

            cliente.ProcessarCoreForma();
            Console.ReadLine();
          
        }
    }
}
