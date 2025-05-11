using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace retotecnico_bcp.Model
{
    public class TipoCambio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int inIdTipoCambio { get; set; }
        public required Moneda monedaOrigen { get; set; }
        public required Moneda monedaDestino { get; set; }
        public Decimal dcTipoCambio { get; set; }
    }
}
