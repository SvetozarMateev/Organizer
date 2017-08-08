<<<<<<< HEAD
﻿using System;
=======
﻿

using System;
using System.Runtime.CompilerServices;
>>>>>>> local-branch
using TODO.Contracts;
using TODO.Utils.Validator;

namespace TODO.Models
{
    public class Note : INote, ISaveable
    {
        private string title;
        private string content;
        private DateTime dateOfCreation;
        private bool isFavourite;

<<<<<<< HEAD
        public Note(string title, string content, bool isFavourite = false, DateTime dateOfCreation = default(DateTime))
=======
        public Note(string title, string content, DateTime dateOfCreation, bool isFavourite = false)
>>>>>>> local-branch
        {
            this.Title = title;
            this.Content = content;
            this.DateOfCreation = dateOfCreation;
            this.IsFavourite = isFavourite;
        }

<<<<<<< HEAD
=======

>>>>>>> local-branch
        public string Title
        {
            get
            {
                return this.title;
            }
            private set
            {
<<<<<<< HEAD
                Validator.CannotBeNullOrEmpty(value);

=======
>>>>>>> local-branch
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
<<<<<<< HEAD
                Validator.CannotBeNullOrEmpty(value);

=======
>>>>>>> local-branch
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
<<<<<<< HEAD
                if (value == default(DateTime))
                {
                    this.dateOfCreation = DateTime.Now;
                }
                else
                {
                    this.dateOfCreation = value;
                }
=======
                this.dateOfCreation = value;
>>>>>>> local-branch
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

<<<<<<< HEAD
        public string FormatUserInfoForDB()
        {
            return $"{this.Title}***{this.IsFavourite}***{this.DateOfCreation.ToString("dd/MM/yyyy")}***{this.Content}";
        }
=======
       
>>>>>>> local-branch
    }
}
