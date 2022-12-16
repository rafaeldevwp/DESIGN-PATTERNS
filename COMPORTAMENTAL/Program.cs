using COMPORTAMENTAL.Command.Command_Exemplo_SQL.Concreto;
using COMPORTAMENTAL.Command.Command_Exemplo_SQL.Invokers;
using COMPORTAMENTAL.Command.Command_Exemplo_SQL.Receivers;
using System;

namespace COMPORTAMENTAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();

            var query = Console.ReadLine();

            invoker.SetCommand(new SQLCommands(receiver, query));
            invoker.ExecutarCommando();

            Console.ReadLine();
        }
    }
}
