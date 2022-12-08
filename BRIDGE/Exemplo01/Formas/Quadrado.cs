using BRIDGE.Exemplo02.Cores;
using System;
using System.Security.Cryptography;

namespace BRIDGE.Exemplo02.Implementacao
{
    public class Quadrado : IForma
    {
        public ICor CorImplementacao { get  ; set; }

        public string ObterCor()
        {
            return this.CorImplementacao.ObterCor();
        }

        public string ObterForma()
        {
            return "Quadrado";
        }
    }
}
