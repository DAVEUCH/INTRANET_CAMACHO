using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteLibroMayorAnalitico
    {
        public int DocumentoPagoId { get; set; }
        public int DocumentoPagoSucursalId { get; set; }
        public int VoucherContablePeriodoId { get; set; }
        public int DocumentoPagoCuentaId { get; set; }
        public string? DocumentoPagoCuentaNumero { get; set; }
        public string? DocumentoPagoCuentaDescripcion { get; set; }
        public string DocumentoPagoTipoAbreviacion { get; set; } = null!;
        public string DocumentoPagoNumero { get; set; } = null!;
        public string DocumentoPagoNumeroContable { get; set; } = null!;
        public string DocumentoPagoPersonaCodigo { get; set; } = null!;
        public string DocumentoPagoPersonaNombre { get; set; } = null!;
        public DateTime DocumentoPagoFechaEmision { get; set; }
        public DateTime DocumentoPagoFecha { get; set; }
        public decimal? DocumentoPagoTotalSoles { get; set; }
        public decimal? DocumentoPagoTotalDolares { get; set; }
        public decimal Cargo { get; set; }
        public decimal Abono { get; set; }
        public string Año { get; set; } = null!;
        public string Mes { get; set; } = null!;
    }
}
