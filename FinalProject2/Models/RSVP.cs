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
        public int UserID { get; set; }
    }
}

