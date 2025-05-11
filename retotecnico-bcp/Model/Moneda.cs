using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace retotecnico_bcp.Model
{
    public class Moneda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int inIdMoneda { get; set; }
        public required string descripcion { get; set; }
    }
}
