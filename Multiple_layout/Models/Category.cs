using System.ComponentModel.DataAnnotations;

namespace Multiple_layout.Models
{
    public class Category
    {
        [Key]
        public int C_id { get; set; }
        [Required]
        public string   C_name { get; set; }    
    }
}
