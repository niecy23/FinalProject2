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

        public IEnumerable<RSVP> GetAllRSVPs()
        {
            return _conn.Query<RSVP>("SELECT * FROM RSVPS;");
        }
    }
}

