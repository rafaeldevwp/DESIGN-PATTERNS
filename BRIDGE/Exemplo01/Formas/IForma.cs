using BRIDGE.Exemplo02.Cores;
using System.Runtime.CompilerServices;

namespace BRIDGE.Exemplo02.Implementacao
{
    public interface IForma
    {
        public ICor CorImplementacao { get; set; }
        string ObterCor();
        string ObterForma();
    }
}
