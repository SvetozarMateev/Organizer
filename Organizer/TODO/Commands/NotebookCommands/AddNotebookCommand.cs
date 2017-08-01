using System;
using System.Collections.Generic;
using System.Linq;
using TODO.Contracts;
using TODO.Engine;

namespace TODO.Commands
{
    public class AddNotebookCommand : Command, ICommand
    {
        public AddNotebookCommand(List<string> parameters)
            : base(parameters)
        {
        }

        public override string Execute
        {
            get
            {
                string notebookName = base.Parameters[1];
                INotebook notebook = base.factory.CreateNotebook(notebookName);
                EngineMaikaTI.loggedUser.AddNotebook(notebook);
                EngineMaikaTI.currentNotebook = notebook;

                return $"Notebook \"{notebookName}\" added successfully !";
            }
        }
    }
}
