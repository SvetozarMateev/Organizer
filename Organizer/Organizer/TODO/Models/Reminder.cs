using System;
using System.Collections.Generic;
using TODO.Contracts;

namespace TODO.Models
{
    public class Reminder : IReminder
    {
        public ICollection<DateTime> MomentsOfBeeping
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void AddMoment(DateTime moment)
        {
            throw new NotImplementedException();
        }

        public void Remind()
        {
            throw new NotImplementedException();
        }

        public void RemoveMoment(DateTime moment)
        {
            throw new NotImplementedException();
        }
    }
}
