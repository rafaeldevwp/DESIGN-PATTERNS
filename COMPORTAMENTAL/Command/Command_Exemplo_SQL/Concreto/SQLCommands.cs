using COMPORTAMENTAL.Command.Command_Exemplo_SQL.Enum;
using COMPORTAMENTAL.Command.Command_Exemplo_SQL.Interface;
using COMPORTAMENTAL.Command.Command_Exemplo_SQL.Receivers;
using System;
using System.Collections.Generic;

namespace COMPORTAMENTAL.Command.Command_Exemplo_SQL.Concreto
{
    public class SQLCommands : ICommand
    {
        public Receiver _receiver;
        public string _query;

        public SQLCommands(Receiver receiver, string query)
        {
            _receiver = receiver;
            _query = query;
        }

        public void Execute()
        {
            if (_query.ToUpper().Contains("INSERT"))
            {
                Console.WriteLine("Iniciando INSERT de dados");
                this._receiver.Insert(_query);
            }

            if (_query.ToUpper().Contains("DELETE"))
            {
                Console.WriteLine("Iniciando DELETE de dados");
                this._receiver.Delete(_query);
            }

            if (_query.ToUpper().Contains("UPDATE"))
            {
                Console.WriteLine("Iniciando UPDATE de dados");
                this._receiver.Update(_query);
            }
        }
    }
}
