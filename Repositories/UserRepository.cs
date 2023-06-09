using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using ToDo.Models;

namespace ToDo.Repositories
{
    public class UserRepository : Repository<User>
    {
        private readonly SqlConnection _connection;

        public UserRepository(SqlConnection connection) : base(connection)
        {
            _connection = connection;
        }

        public void MatchPassword(string email, string password)
        {
            try
            {
                _connection.Get<User>(new { Email = email, Password = password});
                Login.IsLogged(true);
            } catch
            {
                Login.IsLogged(false);
            }
        }
    }
}