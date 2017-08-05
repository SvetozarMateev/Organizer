using System;
using System.Collections.Generic;
using TODO.Contracts;
using TODO.Engine;

namespace TODO.Commands
{
    public class AddLongTermTaskCommand : Command, ICommand
    {     
        public AddLongTermTaskCommand()
        {
        }

        public override string Execute()
        {
            ILongTermTask longTermTask;
            longTermTask = base.factory.CreateLongTermTask(this.Parameters[0],
                this.Parameters[1],
                this.Parameters[2],
                this.Parameters[3]);

            EngineMaikaTI.currentLongTermTask = longTermTask;
            EngineMaikaTI.loggedUser.AddLongTermTask(longTermTask);

            return $"Long term task {this.Parameters[1]} has been added";
        }

        public override void TakeInput()
        {
            List<string> inputParameters = new List<string>();
            inputParameters.Add(this.ReadOneLine("Title:"));
            inputParameters.Add(this.ReadOneLine("Priority:"));
            inputParameters.Add(this.ReadOneLine("End Date:"));
            inputParameters.Add(this.ReadOneLine("Description:"));
            this.Parameters = inputParameters;           
        }
        private string ReadOneLine(string instruction)
        {           
            Console.Write(instruction);
            return Console.ReadLine();
        }
    }
}
