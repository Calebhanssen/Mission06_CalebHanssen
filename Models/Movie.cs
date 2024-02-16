using System.ComponentModel.DataAnnotations;

namespace Mission06_CalebHanssen.Models
{
    public class Movie
    {
        [Key] // Primary key, if you're using a database

        [Required]
        public string Category { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
        public string Title { get; set; }

        [Required]
        public string Year { get; set; } // Assuming year might include range or special formats

        [Required]
        [StringLength(100, ErrorMessage = "Director name cannot be longer than 100 characters.")]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; } // Dropdown values: G, PG, PG-13, R

        public bool Edited { get; set; } // Nullable for non-required field

        public string LentTo { get; set; } // Not required

        [StringLength(25, ErrorMessage = "Notes cannot be longer than 25 characters.")]
        public string Notes { get; set; } // Not required, max 25 chars
    }
}
