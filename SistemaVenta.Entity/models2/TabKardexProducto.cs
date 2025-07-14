using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabKardexProducto
    {
        public string Nombre { get; set; } = null!;
        public int? Idsucursal { get; set; }
        public int? Idalmacen { get; set; }
        public int? IdclaseProductoServicio { get; set; }
        public int? Idmarca { get; set; }
        public int? Idproveedor { get; set; }
        public int? IdconceptoOperacion { get; set; }
        public int? Idcp { get; set; }
        public int? Idproducto { get; set; }
        public string? ProductoCodigo { get; set; }
        public string? ProductoDescripcion { get; set; }
        public string? ComprobanteTipo { get; set; }
        public string? ComprobanteNumCp { get; set; }
        public DateTime? ComprobanteFecha { get; set; }
        public DateTime? ComprobanteFechaEmision { get; set; }
        public DateTime? ComprobanteHoraEmision { get; set; }
        public string? PersonaNombre { get; set; }
        public string? ConceptoOperacionCodigo { get; set; }
        public string? ConceptoOperacionDescripcion { get; set; }
        public string? UnidadBaseAbreviacion { get; set; }
        public string? UnidadReferenciaAbreviacion { get; set; }
        public string? UnidadVentaAbreviacion { get; set; }
        public decimal? ProductoUnidadReferenciaFactor { get; set; }
        public string? Mov { get; set; }
        public decimal? EntradaUnidadReferencia { get; set; }
        public decimal? ValorUnitarioEntrada { get; set; }
        public decimal? ValorEntrada { get; set; }
        public decimal? SalidaUnidadReferencia { get; set; }
        public decimal? ValorUnitarioSalida { get; set; }
        public decimal? ValorSalida { get; set; }
        public decimal? CostoPromedio { get; set; }
        public string? TipoExistenciaCodigo { get; set; }
        public string? TipoExistenciaDescripcion { get; set; }
        public string? TipoOperacionCodigo { get; set; }
        public string? TipoOperacionDescripcion { get; set; }
        public string? TipoComprobantePagoCodigo { get; set; }
        public string? TipoComprobantePagoDescripcion { get; set; }
        public string? DestinoTipoCp { get; set; }
        public string? DestinoNumCp { get; set; }
        public decimal? SaldoInicial { get; set; }
        public decimal? CostoPromedioInicial { get; set; }
        public decimal? CostoTotalInicial { get; set; }
    }
}
