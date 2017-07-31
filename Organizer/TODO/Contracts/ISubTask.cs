using System;

namespace TODO.Contracts
{
    public interface ISubTask : ITask
    {
        string Content { get; }
        double ImportancePercent { get; }
        DateTime DueDate { get; }
    }
}
