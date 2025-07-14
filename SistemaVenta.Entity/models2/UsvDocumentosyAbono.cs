using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvDocumentosyAbono
    {
        public string IdtipoPersona { get; set; } = null!;
        public int Pkid { get; set; }
        public int DocumentoPagoPersonaId { get; set; }
        public string DocumentoPagoPersonaCodigo { get; set; } = null!;
        public string DocumentoPagoPersonaNombre { get; set; } = null!;
        public string? DocumentoPagoPersonaDocumentoIdentidad { get; set; }
        public int DocumentoPagoCuentaId { get; set; }
        public string? DocumentoPagoCuentaNumero { get; set; }
        public string? DocumentoPagoCuentaDescripcion { get; set; }
        public int DocumentoPagoId { get; set; }
        public DateTime DocumentoPagoFechaEmision { get; set; }
        public DateTime DocumentoPagoFecha { get; set; }
        public string TipoCp { get; set; } = null!;
        public DateTime? FechaLetra { get; set; }
        public int DocumentoPagoTipoId { get; set; }
        public string DocumentoPagoTipoAbreviacion { get; set; } = null!;
        public string DocumentoPagoTipoDescripcion { get; set; } = null!;
        public string DocumentoPagoNumero { get; set; } = null!;
        public string DocumentoPagoNumeroContable { get; set; } = null!;
        public decimal? DocumentoPagoMontoSoles { get; set; }
        public decimal? DocumentoPagoMontoDolares { get; set; }
        public decimal DocumentoPagoTipoCambio { get; set; }
        public DateTime DocumentoPagoFechaTipoCambio { get; set; }
        public DateTime DocumentoPagoFechaVencimiento { get; set; }
        public DateTime DocumentoPagoFechaProgramacion { get; set; }
        public DateTime DocumentoPagoFechaUltimoPago { get; set; }
        public decimal? DocumentoCargoSoles { get; set; }
        public decimal? DocumentoAbonoSoles { get; set; }
        public decimal? DocumentoCargoDolares { get; set; }
        public decimal? DocumentoAbonoDolares { get; set; }
        public string DocumentoPagoPorCobrarOpagar { get; set; } = null!;
        public int DocumentoPagoMovimiento { get; set; }
        public int DocumentoPagoSucursalId { get; set; }
        public string DocumentoPagoSucursalNombre { get; set; } = null!;
        public DateTime VoucherContableFecha { get; set; }
        public decimal? DocumentoPagoSaldoTotalSoles { get; set; }
        public string? Vendedor { get; set; }
    }
}
