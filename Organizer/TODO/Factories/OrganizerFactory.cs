﻿using System;
using System.Globalization;
using TODO.Contracts;
using TODO.Models;
using TODO.Utils.GlobalConstants;

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

        public ILongTermTask CreateLongTermTask(string title, string priority, string end, string description)
        {
            Priority resultPriority;
            if (!Enum.TryParse(priority, true, out resultPriority))
            {
                throw new ArgumentException("Wrong Priority");
            }

            return new LongTermTask(title, resultPriority, DateTime.ParseExact(end, Constants.Formats, CultureInfo.InvariantCulture, DateTimeStyles.None), description);
        }

        public ISubTask CreateSubTask(string title, string priority, string end, string description, string importancePercent)
        {
            Priority finalPriority;
            if (!Enum.TryParse(priority, true, out finalPriority))
            {
                throw new ArgumentException("Wrong type of priority");
            }

            DateTime dueDate = DateTime
                .ParseExact(end, Constants.Formats, CultureInfo.InvariantCulture, DateTimeStyles.None);

            return new SubTask(title, finalPriority, description, dueDate, double.Parse(importancePercent));
        }

        public IReminder CreateReminder(string moment)
        {
            //TODO return new Reminder(moment);
            throw new NotImplementedException();
        }
    }
}
