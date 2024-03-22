using System.ComponentModel.DataAnnotations;

namespace Mission11.Models
{
    public class Project
    {
        [Key]
        public int BookId { get; set; }
        public int ISBN { get; set; }
        public string Title { get; set; } 
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Classification { get; set; }
        public string Category { get; set; }
        public int PageCount { get; set; }
        public int Price { get; set; }

    }
}
