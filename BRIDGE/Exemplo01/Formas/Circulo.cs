using BRIDGE.Exemplo02.Cores;
using System;

namespace BRIDGE.Exemplo02.Implementacao
{
    public class Circulo : IForma
    {
        public ICor CorImplementacao { get ; set ; }

        public string ObterCor()
        {
            return this.CorImplementacao.ObterCor();
        }

        public string ObterForma()
        {
            return "Circulo";
        }
    }
}
