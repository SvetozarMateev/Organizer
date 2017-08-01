using System;
using TODO.Contracts;
using TODO.Models;

namespace TODO.Factories
{
    public class OrganizerFactory : IOrganizerFactory
    {
        public INote CreateNote(string title, string content)
        {
            return new Note(title, content);
        }

        public INotebook CreateNotebook(string name)
        {
            return new Notebook(name);
        }

        public IUser CreateUser(string username, string password)
        {
            return new User(username, password);
        }
    }
}
