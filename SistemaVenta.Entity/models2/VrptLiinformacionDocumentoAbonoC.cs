using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptLiinformacionDocumentoAbonoC
    {
        public int DocumentoAbonoItemId { get; set; }
        public decimal ItemRetencionMontoRetencion { get; set; }
        public decimal ItemRetencionAmortizacion { get; set; }
        public decimal ItemRetencionTipoCambio { get; set; }
    }
}
