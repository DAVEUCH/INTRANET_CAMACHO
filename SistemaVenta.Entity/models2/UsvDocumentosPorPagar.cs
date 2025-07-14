using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvDocumentosPorPagar
    {
        public string ProcedenciaProveedor { get; set; } = null!;
        public string DocumentoPagoPersonaNombre { get; set; } = null!;
        public string? DocumentoPagoPersonaDocumentoIdentidad { get; set; }
        public DateTime DocumentoPagoFechaEmision { get; set; }
        public string DocumentoPagoTipoAbreviacion { get; set; } = null!;
        public string DocumentoPagoTipoDescripcion { get; set; } = null!;
        public string DocumentoPagoNumero { get; set; } = null!;
        public string DocumentoPagoNumeroContable { get; set; } = null!;
        public decimal? DocumentoPagoMontoSoles { get; set; }
        public decimal? DocumentoPagoMontoDolares { get; set; }
        public decimal DocumentoPagoTipoCambio { get; set; }
        public DateTime DocumentoPagoFechaVencimiento { get; set; }
        public decimal? DocumentoPagoSaldoSoles { get; set; }
        public decimal? DocumentoPagoSaldoDolares { get; set; }
        public DateTime VoucherContableFecha { get; set; }
    }
}
