using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteDocumentoPagoAmortizacion2
    {
        public DateTime AmortizacionFecha { get; set; }
        public string AmortizacionTipoAbreviacion { get; set; } = null!;
        public string AmortizacionNumero { get; set; } = null!;
        public string AmortizacionNumeroContable { get; set; } = null!;
        public decimal? AmortizacionSoles { get; set; }
        public decimal? AmortizacionDolares { get; set; }
        public decimal AmortizacionTipoCambio { get; set; }
        public DateTime AmortizacionFechaTipoCambio { get; set; }
        public int AmortizacionDocumentoPagoId { get; set; }
        public DateTime AmortizacionDocumentoPagoFechaUltimoPago { get; set; }
        public bool AmortizacionDocumentoPagoPagado { get; set; }
        public int AmortizacionDocumentoPagoPersonaTipoId { get; set; }
        public int AmortizacionIdtipoComprobantePago { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public int IdtipoCp { get; set; }
    }
}
