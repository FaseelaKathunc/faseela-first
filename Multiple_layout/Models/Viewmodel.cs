using System.ComponentModel.DataAnnotations;
namespace Multiple_layout.Models
{
    public class Viewmodel
    {
        [Key]
        public int I_id { get; set; }
        [Required]
        public string I_Name { get; set; }    
        public int C_id {  get; set; }  
        public int P_id{ get; set; }
    }
}
