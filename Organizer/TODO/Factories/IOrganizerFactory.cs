using TODO.Contracts;

namespace TODO.Factories
{
    interface IOrganizerFactory
    {
        IUser CreateUser(string username, string password);

        INotebook CreateNotebook(string name);

        INote CreateNote(string title, string content);
    }
}
