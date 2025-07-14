using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionConsolidadoCarga
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
        public string ConsolidadoComprobanteProductoCodigo { get; set; } = null!;
        public string ConsolidadoComprobanteProductoDescripcion { get; set; } = null!;
        public string LoteFabricacion { get; set; } = null!;
        public string ConsolidadoComprobanteProductoUnidadBase { get; set; } = null!;
        public int ConsolidadoComprobanteProductoFactorReferencia { get; set; }
        public string ConsolidadoComprobanteProductoUnidadReferencia { get; set; } = null!;
        public decimal? ConsolidadoComprobantePeso { get; set; }
        public decimal? ConsolidadoComprobanteVolumen { get; set; }
        public int ConsolidadoComprobanteCantidad { get; set; }
        public string? ConsolidadoComprobanteAlmacenCodigo { get; set; }
        public string? ConsolidadoComprobanteAlmacenNombre { get; set; }
        public string ConsolidadoComprobanteProductoSeccion { get; set; } = null!;
        public int? ConsolidadoComprobanteAlmacenId { get; set; }
        public int? ConsolidadoComprobanteVendedorFuerzaVentaId { get; set; }
        public int ConsolidadoComprobanteVendedorGrupoVentaId { get; set; }
        public int ConsolidadoComprobanteVendedorId { get; set; }
        public string Transportista { get; set; } = null!;
        public string? TransportistaDocIdentidad { get; set; }
        public string TransportistaDireccion { get; set; } = null!;
        public string Placa { get; set; } = null!;
        public string Placa2 { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string Chofer { get; set; } = null!;
        public string? ChoferDocIdentidad { get; set; }
        public string ChoferLicencia { get; set; } = null!;
        public string ProductoClaseProductoServicioCodigo { get; set; } = null!;
        public string ProductoClaseProductoServicioDescripcion { get; set; } = null!;
        public int ConsolidadoVehiculoId { get; set; }
        public int ConsolidadoId { get; set; }
        public string? ClienteDistritoNombre { get; set; }
        public string VendedorEmail { get; set; } = null!;
        public string ComprobanteItemUnidadVentaAbreviacion { get; set; } = null!;
        public int ComprobanteItemUnidadVentaFactor { get; set; }
        public decimal ComprobanteItemCantidadUnidadVenta { get; set; }
        public string ProductoProveedorCodigo { get; set; } = null!;
        public string ProductoProveedorNombre { get; set; } = null!;
        public int ProductoId { get; set; }
        public int? OrdenAmbiente { get; set; }
        public int? OrdenProducto { get; set; }
    }
}
