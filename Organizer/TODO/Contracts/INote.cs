using System;


namespace TODO.Contracts
{
    public interface INote
    {
        string Title { get; }
        string Content { get; }
        DateTime DateOfCreation { get; }
        bool IsFavourite { get; }

        //void Sort();
    }
}
