using System;
using System.Collections.Generic;
using System.Text;

namespace TicketsForm
{
    public class TimeSlot
    {
        public DateTime start;
        public int length;
        public int numTickets;
        public int maxNumTickets;
        public DateTime end;

        public TimeSlot(DateTime start, int length, int maxTickets)
        {
            this.start = start;
            this.length = length;
            this.maxNumTickets = maxTickets;
            this.end = start.AddMinutes(length);
        }

        public bool addTicket()
        {
            if(this.numTickets+1 <= this.maxNumTickets)
            {
                this.numTickets++;
                return true;
            } else
            {
                return false;
            }
        }
    }
}
