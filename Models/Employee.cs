using System.ComponentModel.DataAnnotations;

namespace BookListMVC.Models
{
    public class Book
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}