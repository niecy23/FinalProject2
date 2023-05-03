using System;
using System.Data;
using Dapper;
using FinalProject2.Models;

namespace FinalProject2
{
	public class RSVPRepository : IRSVPRepository
	{
        private readonly IDbConnection _conn;

		public RSVPRepository(IDbConnection conn)
		{
            _conn = conn;
		}

        public RSVP AssignEvent()
        {
            var eventList = GetAllEvents();
            var rSVP = new RSVP();
            rSVP.Events = eventList;
            return rSVP;
        }

        public void DeleteRSVP(RSVP rSVP)
        {
            _conn.Execute("DELETE FROM RSVPs WHERE RSVPID = @id;", new { id = rSVP.RSVPID });
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return _conn.Query<Event>("SELECT * FROM Events;");
        }

        //public int GetRSVPCount()
        //{
        //    return _conn.Query<RSVP>("SELECT * FROM RSVPs;").Count();
        //}

        public IEnumerable<RSVP> GetAllRSVPs()
        {
            return _conn.Query<RSVP>("SELECT Events.EventID, Users.FirstName, Users.LastName FROM Events INNER JOIN Users ON Events.EventID = Users.EventID ORDER BY Events.EventID;");
        }

        public RSVP GetRSVP(int id)
        {
            return _conn.QuerySingle<RSVP>("SELECT * FROM RSVPS WHERE RSVPID = @id", new { id = id });
        }

        public void InsertRSVP(RSVP rSVPToInsert)
        {
            _conn.Execute("INSERT INTO RSVPs (EVENTID, FIRSTNAME, LASTNAME) VALUES (@eventid, @firstname, @lastname);",
            new { eventid = rSVPToInsert.EventID, firstname = rSVPToInsert.FirstName, lastname = rSVPToInsert.LastName});
        }

        public void UpdateRSVP(RSVP rSVP)
        {
            _conn.Execute("UPDATE RSVPs SET EventID = @eventid, FirstName = @firstname, LastName  =@lastname WHERE RSVPID = @id",
            new { eventid = rSVP.EventID, firstname = rSVP.FirstName, lastname = rSVP.LastName, id = rSVP.RSVPID });
        }
    }
}

