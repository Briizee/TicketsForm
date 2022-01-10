using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsForm
{
    public partial class Form1 : Form
    {
        public int minPerWindow;
        public int guestsPerWindow;
        public TimeSpan startTime;
        public TimeSpan endTime;
        public int firstTicketNumber;
        public List<Ticket> queue;

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(int minPerWindow, int guestsPerWindow, TimeSpan start, TimeSpan end, int firstTicket)
        {
            this.minPerWindow = minPerWindow;
            this.guestsPerWindow = guestsPerWindow;
            this.startTime = start;
            this.endTime = end;
            this.firstTicketNumber = firstTicket;
            this.queue = new List<Ticket>();
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            timer1.Enabled = false;
            OptionsForm options = new OptionsForm();
        }

        private void Timer1_Tick(object sender, System.EventArgs e)
        {
            DateTime t = DateTime.Now;
            this.Text = t.ToShortDateString() + " " + t.ToLongTimeString() + " (Open)";

        }

    }
}
