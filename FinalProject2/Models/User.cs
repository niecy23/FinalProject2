using System;
namespace FinalProject2.Models
{
	public class User
	{
		public User()
		{
		}

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}

