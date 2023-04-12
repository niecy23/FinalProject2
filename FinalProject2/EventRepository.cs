using System;
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

        public IEnumerable<Event> GetAllEvents()
        {
            return _conn.Query<Event>("SELECT * FROM EVENTS;");
        }
    }
}

