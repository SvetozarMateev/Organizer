using System;


namespace TODO.Contracts
{
    public interface ISubTask
    {
        string Title { get; }
        string Content { get; }
        double ImportancePercent { get; }
        DateTime DueDate { get; }
        IReminder Reminder { get; }
    }
}
