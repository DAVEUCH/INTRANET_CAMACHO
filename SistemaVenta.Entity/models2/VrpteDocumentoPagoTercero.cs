using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteDocumentoPagoTercero
    {
        public int Identy { get; set; }
        public int DocumentoPagoPersonaTipoId { get; set; }
        public string DocumentoPagoPersonaTipo { get; set; } = null!;
        public int DocumentoPagoPersonaId { get; set; }
        public string DocumentoPagoPersonaCodigo { get; set; } = null!;
        public string DocumentoPagoPersonaNombre { get; set; } = null!;
        public string DocumentoPagoPersonaTipoDocumentoIdentidadCodigo { get; set; } = null!;
        public string? DocumentoPagoPersonaDocumentoIdentidad { get; set; }
        public int DocumentoPagoCuentaId { get; set; }
        public string? DocumentoPagoCuentaNumero { get; set; }
        public string? DocumentoPagoCuentaDescripcion { get; set; }
        public int DocumentoPagoId { get; set; }
        public DateTime DocumentoPagoFechaEmision { get; set; }
        public DateTime DocumentoPagoFecha { get; set; }
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
        public DateTime DocumentoPagoFechaProgramcion { get; set; }
        public DateTime DocumentoPagoFechaUltimoPago { get; set; }
        public decimal? DocumentoPagoSaldoSoles { get; set; }
        public decimal? DocumentoPagoSaldoDolares { get; set; }
        public int DocumentoPagoZonaId { get; set; }
        public string DocumentoPagoZonaCodigo { get; set; } = null!;
        public string DocumentoPagoZonaDescripcion { get; set; } = null!;
        public int DocumentoPagoResponsableId { get; set; }
        public string DocumentoPagoResponsableCodigo { get; set; } = null!;
        public string DocumentoPagoResponsableNombre { get; set; } = null!;
        public bool DocumentoPagoPagado { get; set; }
        public string DocumentoPagoPorCobrarOpagar { get; set; } = null!;
        public int DocumentoPagoMovimiento { get; set; }
        public int DocumentoPagoSucursalId { get; set; }
        public string DocumentoPagoSucursalNombre { get; set; } = null!;
        public bool Credito { get; set; }
        public bool PercepcionValidar { get; set; }
        public decimal PorcentajePercecion { get; set; }
        public decimal? DocumentoPercepcionMontoSoles { get; set; }
        public decimal? DocumentoPercepcionMontoDolares { get; set; }
        public decimal? DocumentoPercepcionSaldoSoles { get; set; }
        public decimal? DocumentoPercepcionSaldoDolares { get; set; }
    }
}
