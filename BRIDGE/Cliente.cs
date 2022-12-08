using BRIDGE.Exemplo02.Cores;
using BRIDGE.Exemplo02.Implementacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BRIDGE
{
    public class Cliente
    {
        public IForma forma { get; set; }
        public void ProcessarCoreForma()
        {
           Console.WriteLine($"A forma escolhida é {forma.ObterForma()} e a cor é {forma.ObterCor()}");
        }
     
    }
}
