using System;
using System.Collections.Generic;

namespace TODO.Contracts
{
    public interface IReminder
    {
        ICollection<DateTime> MomentsOfBeeping { get; }
        void AddMoment(DateTime moment);
        void RemoveMoment(DateTime moment);
        void Remind();
    }
}
