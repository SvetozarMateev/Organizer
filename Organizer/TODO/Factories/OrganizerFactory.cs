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

        public ITask CreateTask(string title, string priority, string description)
        {
            Priority resultPriority;
            if (!Enum.TryParse(priority, true, out resultPriority))
            {
                throw new ArgumentException("Wrong Priority");
            }

            return new Task(title, resultPriority, description);
        }

        public IUser CreateUser(string username, string password)
        {
            return new User(username, password);
        }
    }
}
