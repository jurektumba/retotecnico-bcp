using retotecnico_bcp.Model;

namespace retotecnico_bcp.Response
{
    public class TipoCambioResponse
    {
        public required String monedaOrigen { get; set; }
        public required String monedaDestino { get; set; }
        public Decimal dcTipoCambio { get; set; }
        public Decimal dcMonto { get; set; }
        public Decimal dcMontoConTipoCambio { get; set; }
    }
}
