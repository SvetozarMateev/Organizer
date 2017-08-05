﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO.Contracts;
using TODO.Engine;

namespace TODO.Commands
{
    class AddReminderToTaskCommand : Command, ICommand
    {
        public AddReminderToTaskCommand()
            : base()
        {
        }

        public override string Execute()
        {
            string taskName = base.Parameters[1];
            string momentToRemind = base.Parameters[2];

            IReminder reminder = this.factory.CreateReminder(momentToRemind);
            if (!SearchForTask(taskName))
            {
                throw new ArgumentException("You don't have a task with this name");
            }
            EngineMaikaTI.loggedUser.Tasks.Single(x => x.Title == taskName).Reminder = reminder;

            return $"Created reminder to task: {taskName} successfully !";
        }

        public override void TakeInput()
        {
            throw new NotImplementedException();
        }

        private bool SearchForTask(string taskName)
        {
            foreach (var task in EngineMaikaTI.loggedUser.Tasks)
            {
                if (task.Title == taskName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
