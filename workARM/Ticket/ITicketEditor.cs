using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workARM.Ticket
{
    public interface ITicketEditor
    {
        void UpdateTicket(Ticket ticket);
    }

    public interface ITicketAdder
    {
        void AddTicket(Ticket ticket);
    }

    public interface ITicketRemover
    {
        void RemoveTicket(Ticket ticket);
    }
}
