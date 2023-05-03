using System;
namespace FinalProject2.Models
{
	public class Event
	{
		public Event()
		{
		}

        public int EventID { get; set; }
        public string EventName { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

    }
}

