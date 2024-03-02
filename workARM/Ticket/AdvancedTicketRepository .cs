using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workARM.Ticket
{
    public class AdvancedTicketRepository : ITicketRepository
    {
        private List<Ticket> tickets = new List<Ticket>();

        public void AddTicket(Ticket ticket)
        {
            // Дополнительные действия при добавлении заявки
            tickets.Add(ticket);
        }

        public void RemoveTicket(Ticket ticket)
        {
            // Дополнительные действия при удалении заявки
            tickets.Remove(ticket);
        }

        public void UpdateTicket(Ticket ticket)
        {
            // Дополнительная логика обновления заявки
        }

        public void SomeAdditionalMethod()
        {
            // Дополнительные методы, специфичные для AdvancedTicketRepository
        }
    }
}
