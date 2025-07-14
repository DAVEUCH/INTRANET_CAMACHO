using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteRegistroCompras201002
    {
        public string? NumOc { get; set; }
        public string NumeroContable { get; set; } = null!;
        public string? NumeroCorrelativoAsiento { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string TipoComprobanteAbreviacion { get; set; } = null!;
        public string TipoComprobanteDescripcion { get; set; } = null!;
        public string? TipoComprobantePagoCodigo { get; set; }
        public string? TipoComprobantePagoDescripcion { get; set; }
        public string? NumeroSerie { get; set; }
        public string? Numero { get; set; }
        public string TipoDocumentoIdentidadCodigo { get; set; } = null!;
        public string ClienteCodigo { get; set; } = null!;
        public string ClienteTipoDocumentoIdentidadAbreviacion { get; set; } = null!;
        public string? ClienteDocumentoIdentidad { get; set; }
        public string ClienteNombre { get; set; } = null!;
        public int Idmoneda { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? ValorDescuento { get; set; }
        public int ValorExportacion { get; set; }
        public decimal? ValorAfecto { get; set; }
        public int ValorExonerado { get; set; }
        public decimal? ValorInafecto { get; set; }
        public int ValorIsc { get; set; }
        public decimal? ValorIgv { get; set; }
        public decimal? ValorOtrosCargos { get; set; }
        public decimal? Total { get; set; }
        public decimal TipoDeCambio { get; set; }
        public DateTime ReferenciaFechaEmision { get; set; }
        public string ReferenciaTipoComprobantePagoCodigo { get; set; } = null!;
        public string ReferenciaNumeroSerie { get; set; } = null!;
        public string? ReferenciaNumero { get; set; }
        public string ModalidadCreditoCodigo { get; set; } = null!;
        public string ModalidadCreditoDescripcion { get; set; } = null!;
        public DateTime ComprobanteDetraccionFechaEmision { get; set; }
        public string ComprobanteDetraccionNumero { get; set; } = null!;
        public string AlmacenCodigo { get; set; } = null!;
        public int SucursalId { get; set; }
        public string TipoCp { get; set; } = null!;
        public DateTime? FechaPagoVencimiento { get; set; }
        public int Idperiodo { get; set; }
        public decimal? TotalServicioDespacho { get; set; }
        public int IdcpDoc { get; set; }
        public int IdcptoOperacion { get; set; }
        public string CptoOperacionCodigo { get; set; } = null!;
        public int Reintegro { get; set; }
        public decimal RtsubTotal { get; set; }
        public decimal RtvalorDescuento { get; set; }
        public decimal RtvalorAfecto { get; set; }
        public decimal Rtinafecto { get; set; }
        public decimal RtvalorImpto { get; set; }
        public decimal Rttotal { get; set; }
        public int Iddua { get; set; }
        public string SerieDependenciaAduanera { get; set; } = null!;
        public bool ProveedorAgenteRetencion { get; set; }
        public bool Extranjero { get; set; }
        public string? CodPais { get; set; }
        public string NumCp { get; set; } = null!;
        public int IdlibroAuxiliar { get; set; }
        public int Pkid { get; set; }
    }
}
