using System;
using System.Collections.Generic;
using TODO.Contracts;

namespace TODO.Models
{
    public class Reminder : IReminder
    {
        private ICollection<DateTime> momentsOfBeeping;

        public Reminder()
        {
            this.MomentsOfBeeping = new List<DateTime>();
        }

        public ICollection<DateTime> MomentsOfBeeping
        {
            get
            {
                return this.momentsOfBeeping;
            }
            private set
            {
                this.momentsOfBeeping = value;
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
