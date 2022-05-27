


using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class AplicationDBContext :DbContext
    {

        public AplicationDBContext(DbContextOptions<AplicationDBContext>
            options) : base(options)
        {


        }

        public DbSet<TarjetaCredito> tarjetacredito { get; set; }

    }
}
