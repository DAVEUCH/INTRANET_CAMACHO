using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteLibroRentaCuartum
    {
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string TipoComprobanteAbreviacion { get; set; } = null!;
        public string TipoComprobanteDescripcion { get; set; } = null!;
        public string? TipoComprobantePagoCodigo { get; set; }
        public string? TipoComprobantePagoDescripcion { get; set; }
        public string? NumeroSerie { get; set; }
        public string? Numero { get; set; }
        public string TipoDocumentoIdentidadCodigo { get; set; } = null!;
        public string ClienteCodigo { get; set; } = null!;
        public string? ClienteDocumentoIdentidad { get; set; }
        public string ClienteNombre { get; set; } = null!;
        public decimal? RentaBruta { get; set; }
        public decimal? ImpuestoRenta { get; set; }
        public decimal? OtrasRetenciones { get; set; }
        public decimal? MontoCobrado { get; set; }
        public decimal TipoDeCambio { get; set; }
        public int SucursalId { get; set; }
        public string TipoCp { get; set; } = null!;
        public int Idperiodo { get; set; }
    }
}
