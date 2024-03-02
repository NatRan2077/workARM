using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workARM.Ticket
{
    public class Ticket
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string DeviceName { get; set; }
        public string DeviceIssue { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
