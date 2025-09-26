namespace TaskManager.Data.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
    }
}