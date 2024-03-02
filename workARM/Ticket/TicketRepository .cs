using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workARM.Ticket
{
    public class TicketRepository : ITicketEditor, ITicketAdder, ITicketRemover
    {
        private List<Ticket> tickets = new List<Ticket>();

        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
           
        }

        public void RemoveTicket(Ticket ticket)
        {
            tickets.Remove(ticket);
           
        }

        public void UpdateTicket(Ticket ticket)
        {
           
        }
    }
}
