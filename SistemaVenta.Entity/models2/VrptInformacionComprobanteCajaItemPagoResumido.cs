using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionComprobanteCajaItemPagoResumido
    {
        public int IditemCpCaja { get; set; }
        public decimal? PagoTipoCambio { get; set; }
        public decimal? PagoSolesEfectivo { get; set; }
        public decimal? PagoDolaresEfectivo { get; set; }
        public decimal? PagoSolesNoEfectivo { get; set; }
        public decimal? PagoDolaresNoEfectivo { get; set; }
    }
}
