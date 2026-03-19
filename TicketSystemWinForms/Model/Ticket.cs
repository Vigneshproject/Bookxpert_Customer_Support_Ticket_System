using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemWinForms.Model
{
    public class Ticket
    {
        public int ticketId { get; set; }

        public string? ticketNumber { get; set; }

        public string? subject { get; set; }

        public string? priority { get; set; }

        public string? status { get; set; }

        public DateTime createdDate { get; set; }
    }
}
