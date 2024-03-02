using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workARM.Ticket
{
    public interface ITicketRepository
    {
        
        void AddTicket(Ticket ticket);
        void RemoveTicket(Ticket ticket);
        void UpdateTicket(Ticket ticket);
    }
}

