using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvRegComprasLe81
    {
        public int? Periodo { get; set; }
        public string? Cuo { get; set; }
        public string? NumAsientoCorrelativo { get; set; }
        public string? FechaEmision { get; set; }
        public string? FechaVencimiento { get; set; }
        public string? TipoComprobantePagoCodigo { get; set; }
        public string? NumSerieDocumento { get; set; }
        public string? AñoDua { get; set; }
        public string? NumeroDocumento { get; set; }
        public string NumeroFinal { get; set; } = null!;
        public string? TipoDocIdentidad { get; set; }
        public string? NumeroDocIdentidad { get; set; }
        public string? RazonSocial { get; set; }
        public string? BaseGravada14 { get; set; }
        public string? ImpuestoBaseGravada14 { get; set; }
        public string BaseGravada16 { get; set; } = null!;
        public string ImuestoBaseGravada16 { get; set; } = null!;
        public string? BaseGravada18 { get; set; }
        public string? ImpuestoBaseGravada18 { get; set; }
        public string? ValorNoGravada { get; set; }
        public string? ValorIsc { get; set; }
        public string? ValorOtrosCargos { get; set; }
        public string? ImporteTotal { get; set; }
        public string? CodigoMoneda { get; set; }
        public string? TipoDeCambio { get; set; }
        public string? ReferenciaFechaEmision { get; set; }
        public string? ReferenciaTipoComprobantePago { get; set; }
        public string? ReferenciaNumeroSerie { get; set; }
        public string CodigoDua { get; set; } = null!;
        public string? ReferenciaNumero { get; set; }
        public string? ComprobanteDetraccionFechaEmision { get; set; }
        public string? ComprobanteDetraccionNumero { get; set; }
        public string MarcaDocumentoSujetoRetencion { get; set; } = null!;
        public int ClaseBienyServAdq { get; set; }
        public string CtratoColEmp { get; set; } = null!;
        public string ErrrorTipocambio1 { get; set; } = null!;
        public string ErrrorTipocambio2 { get; set; } = null!;
        public string ErrrorTipocambio3 { get; set; } = null!;
        public string ErrrorTipocambio4 { get; set; } = null!;
        public int CancelaMedioPago { get; set; }
        public int? EstadoIdentificaAnotacion { get; set; }
        public string CampoLibre { get; set; } = null!;
        public int Idperiodo { get; set; }
    }
}
