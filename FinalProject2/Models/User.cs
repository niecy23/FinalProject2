using System;
namespace FinalProject2.Models
{
	public class User
	{
		public User()
		{
		}

        public int UserId { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public int EmailAddress { get; set; }
        public int PhoneNumber { get; set; }
    }
}

