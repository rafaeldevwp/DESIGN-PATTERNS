
using ADAPTER.Enumeradores;
using ADAPTER.Implementacao;
using ADAPTER.Interfaces;
using System.Runtime.CompilerServices;

namespace ADAPTER
{
    public class Cliente 
    {
        public IPagamento ObterTipoPagamento(eTipoPagamento tipoPagamento)
        {
            switch (tipoPagamento)
            {
                case eTipoPagamento.VISA:
                    return new Visa();
                case eTipoPagamento.MASTER:
                    return new Master();
                case eTipoPagamento.BOLETO:
                    return new Boleto();    
                default:
                    return null;
            }

        }

    }
}
