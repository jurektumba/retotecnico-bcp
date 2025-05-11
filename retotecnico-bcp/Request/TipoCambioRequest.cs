using retotecnico_bcp.Model;

namespace retotecnico_bcp.Request
{
    public class TipoCambioRequest
    {
        public required int inIdmonedaOrigen { get; set; }
        public required int inIdmonedaDestino { get; set; }
        public Decimal dcMonto { get; set; }
    }
}
