using COMPORTAMENTAL.Chain_of_Responsibility.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPORTAMENTAL.Chain_of_Responsibility.Sender
{
    public class Sender
    {
        public void RealizarVerificacao()
        {
            SacarValor sacarValor = new SacarValor(123,00.20);
            var saldo = new ServicoConsultarSaldo();
            var Cliente = new ServicoConsultarCliente();

            saldo.AddNext(Cliente);
            saldo.ExecutarVerificacaoServicoPagamento(sacarValor);

        }
    }
}
