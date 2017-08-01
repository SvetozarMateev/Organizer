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
                string content = base.Parameters[2];
                INote note = this.factory.CreateNote(title,content);
                // TODO: note should be added to a notebook

                return $"Note {title} added successfully !";
            }
        }
    }
}
