using System;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace FinalProject2.Models
{
	//public class EventDetailsViewModel
	//{
 //       public Event Event { get; set; }
 //       public int EventID { get; set; }
 //       public string EventName { get; set; }
 //       public DateTime DateAndTime { get; set; }
 //       public string Location { get; set; }
 //       public string Description { get; set; }

 //       public IEnumerable<Event> Events { get; set; }
 //       public List<User> UsersAttending { get; set; }
 //   }

    public class Event
    {
        public Event Events { get; set; }
        public int EventID { get; set; }
        public string EventName { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public IEnumerable<Event> EventsIE { get; set; }
        public List<User> UsersAttending { get; set; }

        //public int UserID { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string EmailAddress { get; set; }
        //public string PhoneNumber { get; set; }
    }
    public class User
    {

        public User()
        {
        }

        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int EventID { get; set; }
        public string EventName { get; set; }
        public IEnumerable<Event> Events { get; set; }

    }

}

