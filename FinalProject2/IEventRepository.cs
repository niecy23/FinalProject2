using System;
using FinalProject2.Models;

namespace FinalProject2
{
	public interface IEventRepository
	{
        public IEnumerable<Event> GetAllEvents();
        public Event GetEvent(int id);
        public void UpdateEvent(Event instance);
        public void InsertEvent(Event instanceToInsert);
        public void DeleteEvent(Event instance);


        public int GetRSVPCount(int id);
        public IEnumerable<Event> GetUsersByEvent(int id);
        public IEnumerable<User> GetRSVPs(int id);

        public IEnumerable<User> GetAllUsers(int id);
    }
}

