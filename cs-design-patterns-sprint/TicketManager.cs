using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_design_patterns_sprint
{
    public class TicketManager : TicketPerson
    {
         private int availableTickets;

    // The manager maintains a list of "observers" - other objects which want to be notified when the tickets change
    private List<ITicketObserver> observers= new List<ITicketObserver>();

    public void Attach(ITicketObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(ITicketObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (ITicketObserver observer in observers)
        {
            observer.Update(availableTickets);
        }
    }
        
    public void SetAvailableTickets(int newAvailableTickets)
    {
        this.availableTickets = newAvailableTickets;

        // Now whenever the tickets amount is changed, we notify all the classes that have added themselves as observers
        Notify();
    }

    public int GetAvailableTickets()
    {
        return availableTickets;
    }
    }
}
