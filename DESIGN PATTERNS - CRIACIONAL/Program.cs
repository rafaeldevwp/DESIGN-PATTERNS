using DESIGN_PATTERNS___CRIACIONAL.Factories;
using DESIGN_PATTERNS___CRIACIONAL.Veiculos;
using System;

namespace DESIGN_PATTERNSCRIACIONAL
{
    public class Program
    {
        static void Main(string[] args)
        {
            Transporte transporte = null;

            if (args.Length > 0  && args[0] == "--uber")
            {
                transporte = new CarroTransporte();
            }
            else if(args.Length > 0 && args[0] == "--log")
            {
                transporte = new MotoTransporte();
            }
            else
            {
                Console.WriteLine("Selecione o tipo de serviço");
            }

            if (transporte != null)
            {
                transporte.IniciarTransporte();
            }
            Console.ReadLine();
        }
    }
}
