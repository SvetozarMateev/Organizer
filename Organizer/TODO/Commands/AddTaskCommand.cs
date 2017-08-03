using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO.Contracts;
using TODO.Engine;

namespace TODO.Commands
{
    class AddTaskCommand : Command, ICommand
    {
        public AddTaskCommand(List<string> parameters)
            : base(parameters)
        {
        }

        public override string Execute()
        {
            string title = base.Parameters[1];
            string priorityStr = Parameters[2];
            string description = string.Join(" ", base.Parameters.Skip(3));

            ITask task = this.factory.CreateTask(title, priorityStr, description);
            EngineMaikaTI.loggedUser.AddTask(task);

            return $"Added tast {title} successfully !";
        }
    }
}
