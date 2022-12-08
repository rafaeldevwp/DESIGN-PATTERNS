using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPORTAMENTAL.Chain_of_Responsibility.Receiver
{
    public class ServicoConsultarCliente : VerificacoesReceiver
    {
        public override SacarValor ExecutarVerificacaoServicoPagamento(SacarValor sacar)
        {
            Console.WriteLine("Consultando dados cliente...");
            return base.ExecutarVerificacaoServicoPagamento(sacar);
        }
    }
}
