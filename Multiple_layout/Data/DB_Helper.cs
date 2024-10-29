using Multiple_layout.Models;
using Microsoft.EntityFrameworkCore;

namespace Multiple_layout.Data
{
    public class DB_Helper:DbContext
    {
        public DB_Helper(DbContextOptions<DB_Helper> options) : base(options)
        {
        }
        public DbSet<Register>tbl_Register { get; set; }
        public DbSet<Category> tbl_category {  get; set; }  
        public DbSet<Product> tbl_products { get; set; }
    }
}
