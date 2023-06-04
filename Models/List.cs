namespace ToDo.Models
{
    public class List
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime DateTime { get; set; }
        public bool Finished { get; set; }
    }
}