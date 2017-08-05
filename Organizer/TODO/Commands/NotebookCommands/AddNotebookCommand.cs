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
            string notebookName = base.Parameters[0];
            INotebook notebook = base.factory.CreateNotebook(notebookName);
            EngineMaikaTI.loggedUser.AddNotebook(notebook);
            EngineMaikaTI.currentNotebook = notebook;

            return $"Notebook \"{notebookName}\" added successfully !";
        }

        public override void TakeInput()
        {
            List<string> inputParameters = new List<string>();
            inputParameters.Add(this.ReadOneLine("Notebook name: "));
            this.Parameters = inputParameters;
        }
    }
}
