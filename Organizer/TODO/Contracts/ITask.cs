﻿using System;
using TODO.Models;

namespace TODO.Contracts
{
    public interface ITask : ISaveable
    {
        string Title { get; }
        string Description { get; }
        DateTime Start { get; }
        IReminder Reminder { get; }
        Priority Priority { get; }

        //void Sort();
    }
}
