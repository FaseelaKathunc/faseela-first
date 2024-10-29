using Microsoft.EntityFrameworkCore;
using Multiple_layout.Models;
using System.ComponentModel.DataAnnotations;
namespace Multiple_layout.Models
    
{
    public class Product
    {
        [Key]
        public int P_id { get; set; }
        [Required]
        public int C_id { get; set; }   
        [Required]
        public string P_name { get; set; }
    }
}
