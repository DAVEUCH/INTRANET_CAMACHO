using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RegistroVentasPrevio
    {
        public string NumCpContable { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string TipoComprobanteAbreviacion { get; set; } = null!;
        public string TipoComprobanteDescripcion { get; set; } = null!;
        public string TipoComprobantePagoCodigo { get; set; } = null!;
        public string? NumeroSerie { get; set; }
        public string? Numero { get; set; }
        public string TipoDocumentoIdentidadCodigo { get; set; } = null!;
        public string? ClienteCodigo { get; set; }
        public string? ClienteDocumentoIdentidad { get; set; }
        public string? PersonaNombre { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? ValorDescuento { get; set; }
        public int ValorExportacion { get; set; }
        public decimal? ValorAfecto { get; set; }
        public int ValorExonerado { get; set; }
        public decimal? ValorInafecto { get; set; }
        public int ValorIsc { get; set; }
        public decimal? ValorIgv { get; set; }
        public int ValorIcb { get; set; }
        public int ValorOtrosCargos { get; set; }
        public decimal? Total { get; set; }
        public int Idmoneda { get; set; }
        public string CodigoMoneda { get; set; } = null!;
        public bool MonedaBase { get; set; }
        public decimal TipoDeCambio { get; set; }
        public DateTime ReferenciaFechaEmision { get; set; }
        public string ReferenciaTipoComprobantePagoCodigo { get; set; } = null!;
        public string? ReferenciaNumeroSerie { get; set; }
        public string? ReferenciaNumero { get; set; }
        public int SucursalId { get; set; }
        public string SucursalCodigo { get; set; } = null!;
        public string SucursalNombre { get; set; } = null!;
        public bool CpAnulado { get; set; }
        public int Idcp { get; set; }
        public int Idperiodo { get; set; }
        public int VendedorId { get; set; }
        public int ConceptoOperacionId { get; set; }
        public bool ResumirEnLibroAuxiliar { get; set; }
    }
}
