using System;
using TODO.Contracts;
using TODO.Models;
using TODO.Utils.GlobalConstants;
using TODO.Utils.Validator;

namespace TODO
{
    public class Task : ITask, ISaveable
    {
        private string title;
        private string description;
        private Priority priority;
        private IReminder reminder;
        private DateTime start;

        public Task(string title, Priority priority, string description)     
        {
            this.Title = title;
            this.Description = description;
            this.Priority = priority;
            this.Start = DateTime.Now;
            this.Reminder = new Reminder();
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

        public string Description
        {
            get
            {
                return this.description;
            }
            private set
            {
                this.description = value;
            }
        }

        public Priority Priority
        {
            get
            {
                return this.priority;
            }
            private set
            {
                this.priority = value;
            }
        }

        public IReminder Reminder
        {
            get
            {
                return this.reminder;
            }
            private set
            {
                this.reminder = value;
            }
        }

        public DateTime Start
        {
            get
            {
                return this.start;
            }
            private set
            {
                this.start = value;
            }
        }

        public string FormatUserInfoForDB()
        {
            return $"{this.Title} {this.Priority} {(this.Reminder.MomentsOfBeeping.Count == 0 ? "" : this.Reminder.ToString())}" +
                $" {this.Start.ToString("dd/MM/yyyy")} {this.Description}";
        }
    }
}
