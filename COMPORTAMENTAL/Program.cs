using COMPORTAMENTAL.Chain_of_Responsibility.Sender;
using System;

namespace COMPORTAMENTAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sender sender = new Sender();
            sender.RealizarVerificacao();
            Console.ReadLine(); 
        }
    }
}
