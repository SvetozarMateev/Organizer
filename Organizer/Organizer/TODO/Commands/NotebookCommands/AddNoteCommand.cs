using System;
using System.Collections.Generic;
using System.Linq;
using TODO.Contracts;
using TODO.Engine;

namespace TODO.Commands
{
    public class AddNoteCommand : Command, ICommand
    {
        public AddNoteCommand(List<string> parameters) 
            : base(parameters)
        {

        }

        public override string Execute
        {
            get
            {
                string title = base.Parameters[1];
                List<string> content = base.Parameters.Skip(2).ToList();
                INote note = this.factory.CreateNote(title,String.Join(" ", content));
                EngineMaikaTI.currentNotebook.AddNote(note);

                return $"Note {title} added successfully !";
            }
        }
    }
}
