using System.ComponentModel.DataAnnotations;

namespace EloTunes.Models
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Nationality { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
    }
}
