using System;
using FinalProject2.Models;

namespace FinalProject2
{
	public interface IRSVPRepository
	{
		public IEnumerable<RSVP> GetAllRSVPs();
	}

    
}

