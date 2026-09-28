using WebAPI_Project.Models;
using Microsoft.EntityFrameworkCore;


namespace WebAPI_Project.Data
{
    public class ApplicationDbContext: DbContext
    {
       public  ApplicationDbContext(

             DbContextOptions<ApplicationDbContext> options) : base(options)

        {

        }
        public DbSet<Product> Products { get; set; }
    }

}
