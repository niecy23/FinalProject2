using System;
namespace FinalProject2.Models
{
    public class WhateverPage
    {
        public WhateverPage(int id)
        {
            Event instance = new Event();
            User user = new User();
        }



        public int EventID { get; set; }
        public string EventName { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public int UserID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public IEnumerable<Event> Events { get; set; }



    }
}

