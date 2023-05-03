using System;
namespace FinalProject2.Models
{
	public class RSVP
	{
		public RSVP()
		{
		}

        public int RSVPID { get; set; }
        public int EventID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Event> Events { get; set; }
    }
}

