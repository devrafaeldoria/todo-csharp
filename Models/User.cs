using Dapper.Contrib.Extensions;

namespace ToDo.Models
{
    [Table("[User]")]
    public class User
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}