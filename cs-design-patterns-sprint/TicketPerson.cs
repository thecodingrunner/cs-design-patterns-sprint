using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_design_patterns_sprint
{
    public interface TicketPerson
    {

        // Attach an observer to the subject.
        void Attach(ITicketObserver observer);

        // Detach an observer from the subject.
        void Detach(ITicketObserver observer);

        // Notify all observers about an event.
        void Notify();
    }
}
