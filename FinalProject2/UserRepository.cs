using System;
using System.Data;
using Dapper;
using FinalProject2.Models;

namespace FinalProject2
{
	public class UserRepository: IUserRepository
	{
        private readonly IDbConnection _conn;

        public UserRepository(IDbConnection conn)
		{
            _conn = conn;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _conn.Query<User>("SELECT * FROM USERS;");
        }
    }
}

