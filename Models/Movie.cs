using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_CalebHanssen.Models
{
    public class Movie
    {
        [Key] // Primary key, if you're using a database
        [Required]
        public int MovieId { get; set; }
      
        public string Title { get; set; }

        public int Year { get; set; } 

        public string? Director { get; set; }

        public string? Rating { get; set; } 

        public int Edited { get; set; } 

        public string? LentTo { get; set; }

        public int CopiedToPlex { get; set; }

        public string? Notes { get; set; } 
       
        
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
 