using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Krdprod
    {
        public int? Idsucursal { get; set; }
        public int? Idalmacen { get; set; }
        public int? IdclaseProductoServicio { get; set; }
        public int? Idmarca { get; set; }
        public int? Idproveedor { get; set; }
        public string? CodigoProveedor { get; set; }
        public string? NombreProveedor { get; set; }
        public int? IdconceptoOperacion { get; set; }
        public int? Idcp { get; set; }
        public int? Idproducto { get; set; }
        public string? ProductoCodigo { get; set; }
        public string? ProductoDescripcion { get; set; }
        public string? ComprobanteTipo { get; set; }
        public string? ComprobanteNumCp { get; set; }
        public DateTime? ComprobanteFecha { get; set; }
        public DateTime? ComprobanteFechaEmision { get; set; }
        public string? PersonaNombre { get; set; }
        public string? ConceptoOperacionCodigo { get; set; }
        public string? ConceptoOperacionDescripcion { get; set; }
        public string? UnidadBaseAbreviacion { get; set; }
        public string? UnidadReferenciaAbreviacion { get; set; }
        public string? UnidadReferenciaCodigo { get; set; }
        public decimal? UnidadReferenciaFactor { get; set; }
        public decimal? EntradaUnidadBase { get; set; }
        public decimal? SalidaUnidadBase { get; set; }
        public string? ClaseProductoCodigo { get; set; }
        public string? ClaseProductoDescripcion { get; set; }
        public string? TipoExistenciaCodigo { get; set; }
        public string? TipoExistenciaDescripcion { get; set; }
        public string? TipoOperacionCodigo { get; set; }
        public string? TipoOperacionDescripcion { get; set; }
        public string? TipoComprobantePagoCodigo { get; set; }
        public string? TipoComprobantePagoDescripcion { get; set; }
        public string? CodigoAlmacen { get; set; }
        public string? NombreAlmacen { get; set; }
        public decimal? SaldoInicial { get; set; }
    }
}
