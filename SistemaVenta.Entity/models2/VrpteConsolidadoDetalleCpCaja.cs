using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteConsolidadoDetalleCpCaja
    {
        public int CpCajaId { get; set; }
        public int? DocPagadoId { get; set; }
        public DateTime? DocPagadoFechaEmision { get; set; }
        public string? DocPagadoNumCp { get; set; }
        public decimal? DocPagadoTotal { get; set; }
        public decimal DocPagadoAmortizacion { get; set; }
        public string MedioPago { get; set; } = null!;
        public string MedioPagoNumero { get; set; } = null!;
        public string? DocPagadoTipoCp { get; set; }
        public string? DocPagadoTipoCpCobrarPagar { get; set; }
        public bool? DocPagadoAnulado { get; set; }
        public string? DocPagadoResponsableCodigo { get; set; }
        public string? DocPagadoResponsableNombre { get; set; }
        public string DocPagadoModPago { get; set; } = null!;
    }
}
