using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteCuentaCorrientePersona
    {
        public int DocumentoPagoPersonaId { get; set; }
        public string DocumentoPagoPersonaCodigo { get; set; } = null!;
        public string DocumentoPagoPersonaNombre { get; set; } = null!;
        public string? DocumentoPagoCuentaNumero { get; set; }
        public DateTime DocumentoPagoFechaEmision { get; set; }
        public DateTime DocumentoPagoFecha { get; set; }
        public string DocumentoPagoTipoAbreviacion { get; set; } = null!;
        public string DocumentoPagoNumero { get; set; } = null!;
        public string DocumentoPagoNumeroContable { get; set; } = null!;
        public decimal? DocumentoPagoSolesCargo { get; set; }
        public decimal? DocumentoPagoSolesAbono { get; set; }
        public decimal? DocumentoPagoDolaresCargo { get; set; }
        public decimal? DocumentoPagoDolaresAbono { get; set; }
        public DateTime AmortizacionFecha { get; set; }
        public string AmortizacionTipoAbreviacion { get; set; } = null!;
        public string AmortizacionNumero { get; set; } = null!;
        public string AmortizacionNumeroContable { get; set; } = null!;
        public decimal? AmortizacionSolesCargo { get; set; }
        public decimal? AmortizacionSolesAbono { get; set; }
        public decimal? AmortizacionDolaresCargo { get; set; }
        public decimal? AmortizacionDolaresAbono { get; set; }
    }
}
