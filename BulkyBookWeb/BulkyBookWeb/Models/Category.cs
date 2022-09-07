namespace BulkyBookWeb.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int DisplayOrdered { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
