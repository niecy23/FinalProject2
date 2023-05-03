using System;
using FinalProject2.Models;

namespace FinalProject2
{
	public interface IRSVPRepository
	{
        public IEnumerable<RSVP> GetAllRSVPs();
        //public int GetRSVPCount();
        public RSVP GetRSVP(int id);
        public void UpdateRSVP(RSVP rSVP);
        public void InsertRSVP(RSVP rSVPToInsert);
        public IEnumerable<Event> GetAllEvents();
        public RSVP AssignEvent();
        public void DeleteRSVP(RSVP rSVP);
    }

    
}

