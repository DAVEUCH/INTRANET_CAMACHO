using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionConsolidadoCargaRechazo
    {
        public DateTime ConsolidadoFecha { get; set; }
        public string ConsolidadoNumero { get; set; } = null!;
        public string ConsolidadoVehiculoCodigo { get; set; } = null!;
        public string ConsolidadoVehiculoNombre { get; set; } = null!;
        public DateTime ConsolidadoComprobanteFecha { get; set; }
        public string ConsolidadoComprobanteNumCp { get; set; } = null!;
        public string ConsolidadoComprobanteVendedorCodigo { get; set; } = null!;
        public string ConsolidadoComprobanteVendedorNombre { get; set; } = null!;
        public string? ConsolidadoComprobanteVendedorGrupoVentaCodigo { get; set; }
        public string? ConsolidadoComprobanteVendedorGrupoVentaNombre { get; set; }
        public string? ConsolidadoComprobanteVendedorFuerzaVentaCodigo { get; set; }
        public string? ConsolidadoComprobanteVendedorFuerzaVentaNombre { get; set; }
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public string ProductoUnidadBaseAbreviacion { get; set; } = null!;
        public int ProductoUnidadReferenciaFactor { get; set; }
        public string ProductoUnidadReferenciaAbreviacion { get; set; } = null!;
        public int ConsolidadoComprobanteCantidad { get; set; }
        public decimal ConsolidadoComprobanteMonto { get; set; }
        public string? ConsolidadoComprobanteAlmacenCodigo { get; set; }
        public string? ConsolidadoComprobanteAlmacenNombre { get; set; }
        public string ConsolidadoComprobanteRechazoCodigo { get; set; } = null!;
        public string ConsolidadoComprobanteRechazoDescripcion { get; set; } = null!;
        public int? ConsolidadoComprobanteAlmacenId { get; set; }
        public int? ConsolidadoComprobanteVendedorFuerzaVentaId { get; set; }
        public int ConsolidadoComprobanteVendedorGrupoVentaId { get; set; }
        public int ConsolidadoComprobanteVendedorId { get; set; }
        public int ConsolidadoComprobanteRechazoId { get; set; }
        public string ClienteCodigo { get; set; } = null!;
        public string ClienteNombre { get; set; } = null!;
        public int ProductoProveedorId { get; set; }
        public int ProductoClaseProductoId { get; set; }
        public int ProductoMarcaId { get; set; }
        public int ProductoId { get; set; }
        public decimal? ProductoItemPeso { get; set; }
        public decimal? ProductoItemVolumen { get; set; }
    }
}
