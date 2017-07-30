

using System;
using System.Runtime.CompilerServices;
using TODO.Contracts;

namespace TODO.Models
{
    public class Note : INote
    {
        private string title;
        private string content;
        private DateTime dateOfCreation;
        private bool isFavourite;

        public Note(string title, string content, DateTime dateOfCreation, bool isFavourite = false)
        {
            this.Title = title;
            this.Content = content;
            this.DateOfCreation = dateOfCreation;
            this.IsFavourite = isFavourite;
        }


        public string Title
        {
            get
            {
                return this.title;
            }
            private set
            {
                this.title = value;
            }
        }

        public string Content
        {
            get
            {
                return this.content;
            }
            set
            {
                this.content = value;
            }
        }

        public DateTime DateOfCreation
        {
            get
            {
                return this.dateOfCreation;
            }
            private set
            {
                this.dateOfCreation = value;
            }
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

       
    }
}
