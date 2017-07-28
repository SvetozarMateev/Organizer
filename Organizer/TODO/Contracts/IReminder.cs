using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
