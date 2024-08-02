using System.ComponentModel.DataAnnotations;

namespace MovieProject.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Required(ErrorMessage = "The Title is required.")]
        public string Title { get; set; } 
        [Required(ErrorMessage = "The Actor is required.")]

        public string Actor { get; set; }

        [Required(ErrorMessage = "The Language is required.")]

        public string Lang { get; set; }

        [Required(ErrorMessage = "The Director is required.")]

        public string Director { get; set; }
    }
}
