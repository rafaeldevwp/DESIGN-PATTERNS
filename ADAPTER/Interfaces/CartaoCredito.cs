namespace ADAPTER.Interfaces
{
    public abstract class CartaoCredito : IPagamento
    {
        IPagamento pagamento;

        public virtual void CobrarFatura()
        {
            pagamento.CobrarFatura();
        }
    }
}
