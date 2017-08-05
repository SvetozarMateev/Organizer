using System;
using System.Collections.Generic;
using System.Linq;
using TODO.Contracts;
using TODO.Engine;

namespace TODO.Commands
{
    class AddTaskCommand : Command, ICommand
    {
        public AddTaskCommand()
            : base()
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

        public override void TakeInput()
        {
            throw new NotImplementedException();
        }
    }
}
