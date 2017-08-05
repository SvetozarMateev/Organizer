using System;
using System.Collections.Generic;
using System.Linq;
using TODO.Contracts;
using TODO.Engine;

namespace TODO.Commands
{
    public class AddNoteCommand : Command, ICommand
    {
        public AddNoteCommand()
            : base()
        {

        }

        public override string Execute()
        {
            string title = base.Parameters[0];
            string content = base.Parameters[1];
            INote note = this.factory.CreateNote(title,content);
            EngineMaikaTI.currentNotebook.AddNote(note);

            return $"Note {title} added successfully !";
        }

        public override void TakeInput()
        {
            List<string> inputParameters = new List<string>();
            inputParameters.Add(this.ReadOneLine("Title: "));
            inputParameters.Add(this.ReadOneLine("Content: "));
        }
    }
}
