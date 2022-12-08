using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPORTAMENTAL.Chain_of_Responsibility.Receiver
{
    public abstract class VerificacoesReceiver
    {
        public VerificacoesReceiver Next = null;
        
        public VerificacoesReceiver AddNext(VerificacoesReceiver next)
        {
            this.Next = next;
            return next;
        }

        public virtual SacarValor ExecutarVerificacaoServicoPagamento(SacarValor sacar)
        {
            if (this.Next != null)
                return this.Next.ExecutarVerificacaoServicoPagamento(sacar);
            return null;
        }
        
    }
}
