namespace TaskManager.Data.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}