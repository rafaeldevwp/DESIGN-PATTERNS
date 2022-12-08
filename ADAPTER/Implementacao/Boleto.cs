using ADAPTER.Interfaces;
using System;

namespace ADAPTER.Implementacao
{
    public class Boleto : IPagamento
    {
        public Boleto()
        {
            this.CobrarFatura();
        }

        public void CobrarFatura()
        {
            Console.WriteLine("Pagamento em Boleto");
        }
    }
}
