using COMPORTAMENTAL.Command.Command_Exemplo_SQL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace COMPORTAMENTAL.Command.Command_Exemplo_SQL.Invokers
{
    public class Invoker
    {
       private ICommand _command;

        public void SetCommand(ICommand command)
        {
            this._command = command;
        }

        public void ExecutarCommando()
        {
            _command.Execute();
        }
    }
}
