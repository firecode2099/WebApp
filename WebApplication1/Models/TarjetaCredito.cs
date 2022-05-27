using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class TarjetaCredito
    {

        [Key]
        
        public int id { get; set; }
        public string Titular { get; set; }
        public string NumeroTarjeta { get; set; }
        public string FechaExpiracion { get; set; }
        public string cvv { get; set; }
    }
}
