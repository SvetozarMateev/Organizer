using System;
using System.Collections.Generic;
using TODO.Contracts;
using TODO.Engine;

namespace TODO.Commands
{
    public class AddSubtaskCommand : Command, ICommand
    {
        public AddSubtaskCommand() 
            : base()
        {
        }

        public override string Execute()
        {
            string title = this.Parameters[0];
            string priority = this.Parameters[1];
            string end = this.Parameters[2];
            string description = this.Parameters[3];
            string importancePercent = this.Parameters[4];
           ISubTask currSubtask= this.factory
                .CreateSubTask(title, priority, end, description, importancePercent);
            
            EngineMaikaTI.currentLongTermTask.AddSubTask(currSubtask);

            return $"Sub task {title} added to {EngineMaikaTI.currentLongTermTask}";
        }

        public override void TakeInput()
        {
            List<string> inputParameters = new List<string>();
            inputParameters.Add(this.ReadOneLine("Title: "));
            inputParameters.Add(this.ReadOneLine("Priority: "));
            inputParameters.Add(this.ReadOneLine("End date: "));
            inputParameters.Add(this.ReadOneLine("Description: "));
            inputParameters.Add(this.ReadOneLine("Importance percent: "));
            this.Parameters = inputParameters;
        }
    }
}
