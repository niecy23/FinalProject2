using System;
using FinalProject2.Models;

namespace FinalProject2
{
	public interface IUserRepository
	{
        public IEnumerable<User> GetAllUsers();
    }
}

