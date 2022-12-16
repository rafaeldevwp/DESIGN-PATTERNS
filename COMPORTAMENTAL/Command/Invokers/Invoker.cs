

using COMPORTAMENTAL.Command.Interfaces;
using System;

namespace COMPORTAMENTAL.Command.Invokers
{
    public class Invoker
    {
        private ICommand _onStart;
        private ICommand _onFinish;

        public void SetOnStart(ICommand command)
        {
            this._onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            this._onFinish = command;
        }


        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker");

            if (this._onStart is ICommand)
            {
                this._onStart.Execute();
            }

            Console.WriteLine("Invoker: ...doing something really important...");
            Console.WriteLine("Invoker: Does anybody want something done after I finish?");

            if (this._onFinish is ICommand)
            {
                this._onFinish.Execute();
            }


        }



    }
}
