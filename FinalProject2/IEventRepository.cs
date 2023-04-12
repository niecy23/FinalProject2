using System;
using System.Collections.Generic;
using FinalProject2.Models;

namespace FinalProject2
{
	public interface IEventRepository
	{
        public IEnumerable<Event> GetAllEvents();
    }
}

