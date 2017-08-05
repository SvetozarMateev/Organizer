using System;
using System.Collections.Generic;
using TODO.Contracts;
using TODO.Engine;

namespace TODO.Commands
{
    public class AddNotebookCommand : Command, ICommand
    {
        public AddNotebookCommand()
            : base()
        {
        }

        public override string Execute()
        {
            string notebookName = base.Parameters[1];
            INotebook notebook = base.factory.CreateNotebook(notebookName);
            EngineMaikaTI.loggedUser.AddNotebook(notebook);
            EngineMaikaTI.currentNotebook = notebook;

            return $"Notebook \"{notebookName}\" added successfully !";
        }

        public override void TakeInput()
        {
            throw new NotImplementedException();
        }
    }
}
