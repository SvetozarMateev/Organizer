using System;
using System.Collections.Generic;
using System.Linq;
using TODO.Contracts;
using TODO.Utils.Validator;

namespace TODO.Models
{
    public class Notebook : INotebook, ISaveable
    {
        private string name;
        private IUser user;
<<<<<<< HEAD
        private ICollection<INote> notes;
        private bool isFavourite;

        public Notebook(string name, bool isFavourite = false, List<INote> notes = null)
        {
            this.Name = name;
            this.Notes = notes;
            this.IsFavourite = isFavourite;
           // this.User = EngineMaikaTI.loggedUser;
=======
        private ICollection<Note> notes;
        private bool isFavourite;

        public Notebook(string name, IUser user, ICollection<Note> notes, bool isFavourite = false)
        {
            this.Name = name;
            this.User = user;
            this.Notes = notes;
            this.IsFavourite = isFavourite;
>>>>>>> local-branch
        }

        public bool IsFavourite
        {
            get
            {
                return this.isFavourite;
            }
            set
            {
<<<<<<< HEAD
                this.isFavourite = value;
=======
                this.IsFavourite = value;
>>>>>>> local-branch
            }
        }

        public string Name
        {
            get
            {
                return this.name;
<<<<<<< HEAD
=======
            }
            set
            {
                this.name = value;
>>>>>>> local-branch
            }
            set
            {
<<<<<<< HEAD
                Validator.CannotBeNullOrEmpty(value);

                this.name = value;
=======
                return this.notes;
            }
            set
            {
                this.notes = value;
>>>>>>> local-branch
            }
        }

        public ICollection<INote> Notes
        {
            get
            {
<<<<<<< HEAD
                return this.notes;
            }
            set
            {
                if (value == null)
                {
                    this.notes = new List<INote>();
                }
                else
                {
                    this.notes = value;
                }
            }
        }

       //public IUser User
       // {
       //     get
       //     {
       //         return this.user;
       //     }
       //     set
       //     {
       //         this.user = value;
       //     }
       // } 

        public void AddNote(INote note)
=======
                return this.user;
            }
            set
            {
                this.user = value;
            }
        }


        public void AddNote(Note note)
>>>>>>> local-branch
        {
            this.Notes.Add(note);
        }

        public void DeleteNote(Note note)
        {
            throw new NotImplementedException();
        }

        public void EditNote(Note note)
        {
            throw new NotImplementedException();
        }
        public void Sort()
        {
            throw new NotImplementedException();
        }
      

        public string FormatUserInfoForDB()
        {
            return $"{this.Name}:::{this.IsFavourite}:::{(this.Notes.Count==0?"None":string.Join(",,,", this.Notes.Select(x=>x.FormatUserInfoForDB())))}";
        }
    }
}
