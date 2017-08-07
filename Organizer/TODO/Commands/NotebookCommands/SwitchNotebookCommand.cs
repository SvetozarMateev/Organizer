using System;
using System.Collections.Generic;
using TODO.Engine;
using TODO.Utils.GlobalConstants;

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
            string newNotebookName = base.Parameters[0];

            if (!SearchForNotebook(newNotebookName))
            {
                return Messages.WrongNotebookName();
            }

            return Messages.NotebookSwitched(newNotebookName);
        }

        public override void TakeInput()
        {
            List<string> inputParameters = new List<string>();
            inputParameters.Add(this.ReadOneLine("Notebook name: "));
            this.Parameters = inputParameters;
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
