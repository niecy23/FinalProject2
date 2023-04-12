using System;
namespace FinalProject2.Models
{
	public class Event
	{
		public Event()
		{
		}

        public int EventID { get; set; }
        public int EventName { get; set; }
        public int Date { get; set; }
        public int Time { get; set; }
        public int Location { get; set; }
        public int Description { get; set; }

    }
}

