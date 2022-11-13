using ABSTRACT_FACTORY.Factories;
using System;

namespace ABSTRACT_FACTORY
{
    internal class Program
    {
        static Aplicacao ConfigureApplication()
        {
            Aplicacao app;
            
            ITransporteFactory transporteFactory;

            string company = "99";

            if (company == "Uber")
            {
                transporteFactory = new UberTransporte();
            }
            else
            {
                transporteFactory = new NineNineTransporte();
            }

            app = new Aplicacao(transporteFactory);

            return app;

        }

        static void Main(string[] args)
        {
            Aplicacao app = ConfigureApplication();
            app.IniciarTrajeto();

            Console.ReadLine();
        }
    }
}
