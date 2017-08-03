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
    public class AddLongTermTaskCommand : Command, ICommand
    {
        public AddLongTermTaskCommand(List<string> parameters) : base(parameters)
        {
        }

        public override string Execute()
        {
            ILongTermTask longTermTask;
            longTermTask = base.factory
                .CreateLongTermTask(this.Parameters[1], this.Parameters[2], this.Parameters[3], this.Parameters[4]);
            EngineMaikaTI.currentLongTermTask = longTermTask;
            EngineMaikaTI.loggedUser.AddLongTermTask(longTermTask);
            return $"Long term task {this.Parameters[1]} has been added";
        }
    }
}
