using System;
using System.Collections.Generic;
using TODO.Engine;

namespace TODO.Commands
{
    public class SwitchNotebookCommand : Command, ICommand
    {
        public SwitchNotebookCommand()
            : base()
        {
        }

        public override string Execute()
        {
            string newNotebookName = base.Parameters[1];

            if (!SearchForNotebook(newNotebookName))
            {
                return $"You don't have a notebook with this name";
            }

            return $"Successfully switched to {newNotebookName} notebook";
        }

        public override void TakeInput()
        {
            throw new NotImplementedException();
        }

        private bool SearchForNotebook(string newNotebookName)
        {
            foreach (var nb in EngineMaikaTI.loggedUser.Notebooks) // searches if the user has a notebook with the given name.
            {
                if (nb.Name == newNotebookName)
                {
                    EngineMaikaTI.currentNotebook = nb;
                    return true;
                }
            }

            return false;
        }
    }
}
