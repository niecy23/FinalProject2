using System.Data;
using Dapper;
using FinalProject2.Models;

namespace FinalProject2
{
    public class EventRepository : IEventRepository
	{
        private readonly IDbConnection _conn;

        public EventRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public void DeleteEvent(Event instance)
        {
            _conn.Execute("DELETE FROM Events WHERE EventID = @id;", new { id = instance.EventID });
            _conn.Execute("DELETE FROM RSVPs WHERE EventID = @id;", new { id = instance.EventID });
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return _conn.Query<Event>("SELECT * FROM EVENTS;");
        }

        public Event GetEvent(int id)
        {
            return _conn.QuerySingle<Event>("SELECT * FROM EVENTS WHERE EVENTID = @id", new { id = id });
        }

        public void InsertEvent(Event instanceToInsert)
        {
            _conn.Execute("INSERT INTO Events (EventName, DateAndTime, Location, Description) VALUES (@eventname, @dateandtime, @location, @description);",
        new { eventname = instanceToInsert.EventName, dateandtime = instanceToInsert.DateAndTime, Location = instanceToInsert.Location, description = instanceToInsert.Description });

        }

        public void UpdateEvent(Event instance)
        {
            _conn.Execute("UPDATE Events SET EventName = @name, DateAndTime = @dateandtime, Location = @location, Description = @description WHERE EventID = @id",
            new{ name = instance.EventName, dateandtime = instance.DateAndTime, location = instance.Location, description = instance.Description, id = instance.EventID });
        }
    }
}

