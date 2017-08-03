using System;
using System.Collections.Generic;
using System.Linq;
using TODO.Contracts;
using TODO.Engine;

namespace TODO.Models
{
    public class Notebook : INotebook, ISaveable
    {
        private string name;
        private IUser user;
        private ICollection<INote> notes;
        private bool isFavourite;

        public Notebook(string name, bool isFavourite = false, List<INote> notes = null)
        {
            this.Name = name;
            this.Notes = notes;
            this.IsFavourite = isFavourite;
           // this.User = EngineMaikaTI.loggedUser;
        }

        public bool IsFavourite
        {
            get
            {
                return this.isFavourite;
            }
            set
            {
                this.isFavourite = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public ICollection<INote> Notes
        {
            get
            {
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
            return $"{this.Name} {this.IsFavourite}:::{string.Join(",,,", this.Notes.Select(x=>x.FormatUserInfoForDB()))}";
        }
    }
}
