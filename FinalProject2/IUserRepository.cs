using System;
using FinalProject2.Models;

namespace FinalProject2
{
	public interface IUserRepository
	{
        public IEnumerable<User> GetAllUsers();
        public User GetUser(int id);
        public void UpdateUser(User user);
        public void InsertUser(User userToInsert);
        public IEnumerable<Event> GetAllEvents();
        public User AssignEvent();
        public void DeleteUser(User user);
    }
}

