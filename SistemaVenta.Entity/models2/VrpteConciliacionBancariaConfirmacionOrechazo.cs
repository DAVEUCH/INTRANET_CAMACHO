using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteConciliacionBancariaConfirmacionOrechazo
    {
        public int ComprobanteId { get; set; }
        public int ComprobanteMovimientoSaldoContable { get; set; }
        public int ComprobanteMovimientoSaldoDisponible { get; set; }
        public int ComprobanteCajaId { get; set; }
        public int MedioDePagoId { get; set; }
        public DateTime MedioDePagoFechaConfirmacionOrechazo { get; set; }
    }
}
