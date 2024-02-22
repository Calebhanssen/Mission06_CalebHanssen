using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_CalebHanssen.Models
{
    public class Category
    {
        [Key]

        public int CategoryId { get; set; }


        [Column("Category")]
        public string CategoryName { get; set; }
    
    }
}
