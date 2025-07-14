using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformeDiarioResuman
    {
        public string CajaCodigo { get; set; } = null!;
        public string CajaNombre { get; set; } = null!;
        public string ConceptoOperacionCodigo { get; set; } = null!;
        public string ConceptoOperacionDescripcion { get; set; } = null!;
        public decimal? ItemComprobanteCargoSoles { get; set; }
        public decimal? ItemComprobanteAbonoSoles { get; set; }
        public decimal? ItemComprobanteCargoDolares { get; set; }
        public decimal? ItemComprobanteAbonoDolares { get; set; }
        public string Abono { get; set; } = null!;
        public DateTime ComprobanteFecha { get; set; }
        public int CajaId { get; set; }
    }
}
