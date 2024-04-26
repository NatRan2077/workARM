using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workARM
{
    public interface IMakeTicketLogic
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Post { get; set; }
        public string Model { get; set; }
        public string Breaking { get; set; }
    }
}
