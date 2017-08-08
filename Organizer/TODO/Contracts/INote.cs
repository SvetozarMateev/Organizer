using System;

namespace TODO.Contracts
{
    public interface INote: ISaveable
    {
        string Title { get; }
        string Content { get; }
        DateTime DateOfCreation { get; }
<<<<<<< HEAD
        bool IsFavourite { get; set; }


=======
        bool IsFavourite { get; }

        //void Sort();
>>>>>>> local-branch
    }
}
