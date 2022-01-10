using System;
using System.Collections.Generic;
using System.Text;

namespace TicketsForm
{
    public class Ticket
    {
        public int number;
        public TimeSlot time;

        public Ticket(int number, TimeSlot timeSlot)
        {
            this.number = number;
            this.time = timeSlot;
        }

        public int getNextTicketNumber()
        {
            return this.number + 1;
        }

        public string getDisplayText()
        {
            string displayText = String.Format("Ticket {0}: {1}", this.number, this.time);
            return displayText;
        }
    }
}
