using System.ComponentModel.DataAnnotations;

namespace Multiple_layout.Models
{
    public class viewmodel_index
    {
        [Key]
        public int P_id { get; set; }
        [Required]
        public int C_id { get; set; }
        [Required]
        public string P_name { get; set; }
        [Required]
        public string C_name { get; set; }
    }
}
