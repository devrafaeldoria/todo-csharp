using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace ToDo.Repositories
{
    public class Repository<T> where T : class
    {
        private readonly SqlConnection _connection;

        public Repository(SqlConnection connection)
        {
            _connection = connection;
        }

        public void Create(T model)
        {
            _connection.Insert(model);
        }

        public IEnumerable<T> GetAll()
        {
            return _connection.GetAll<T>();
        }

        public void Remove(T model)
        {
            _connection.Delete<T>(model);
        }

        public void Update(T model)
        {
            _connection.Update<T>(model);
        }


    }
}