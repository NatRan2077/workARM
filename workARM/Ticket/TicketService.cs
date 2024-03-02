using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workARM.Ticket
{
    public class TicketService
    {
        private ITicketRepository ticketRepository;

        public TicketService(ITicketRepository repository)
        {
            this.ticketRepository = repository;
        }

        public void CreateTicket(Ticket ticket)
        {
            ticketRepository.AddTicket(ticket);
        }

        public void RemoveTicket(Ticket ticket)
        {
            ticketRepository.RemoveTicket(ticket);
        }

        public void UpdateTicket(Ticket ticket)
        {
            ticketRepository.UpdateTicket(ticket);
        }
    }
}
