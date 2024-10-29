
using Multiple_layout.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Multiple_layout.Models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Dob { get; set; }
        [Required]  
        public string type {  get; set; }   

    }
}
