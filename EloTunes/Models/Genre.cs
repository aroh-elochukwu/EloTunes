using System.ComponentModel.DataAnnotations;

namespace EloTunes.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Invented { get; set; }

    }
}
