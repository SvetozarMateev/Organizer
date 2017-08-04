using System.Collections.Generic;
using TODO.Contracts;
using TODO.Engine;

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
            {
                currSubtask = this.factory.CreateSubTask(this.Parameters[1],
                    this.Parameters[2],
                    this.Parameters[3],
                    this.Parameters[4],
                    this.Parameters[5]
                   );
            }
            else
            {
                currSubtask = this.factory.CreateSubTask(this.Parameters[1], 
                    this.Parameters[2], 
                    this.Parameters[3], 
                    this.Parameters[4],
                    this.Parameters[5]);
            }

            EngineMaikaTI.currentLongTermTask.AddSubTask(currSubtask);

            return $"Sub task {this.Parameters[1]} added to {EngineMaikaTI.currentLongTermTask}";
        }
    }
}
