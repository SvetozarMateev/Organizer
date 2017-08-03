using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO.Contracts;
using TODO.Engine;
using TODO.Models;

namespace TODO.Commands
{
    public class AddSubtaskCommand : Command, ICommand
    {
        public AddSubtaskCommand(List<string> parameters) : base(parameters)
        {
        }

        public override string Execute()
        {
            ISubTask currSubtask;
            if (this.Parameters.Count == 6)
                currSubtask=this.factory.CreateSubTask(this.Parameters[1], this.Parameters[2], this.Parameters[3], this.Parameters[4], this.Parameters[5],this.Parameters[6]);
            else
                currSubtask=this.factory.CreateSubTask(this.Parameters[1], this.Parameters[2], this.Parameters[3], this.Parameters[4],this.Parameters[5]);

            EngineMaikaTI.currentLongTermTask.AddSubTask(currSubtask);
            return $"Sub task {this.Parameters[1]} added to {EngineMaikaTI.currentLongTermTask}";
        }
    }
}
