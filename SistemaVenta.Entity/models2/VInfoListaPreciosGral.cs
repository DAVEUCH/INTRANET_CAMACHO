using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoListaPreciosGral
    {
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public bool ProductoDeasactivado { get; set; }
        public string ProductoLineaDescripcion { get; set; } = null!;
        public string ProductoProveedorNombre { get; set; } = null!;
        public bool ProductoAplicaPercepcion { get; set; }
        public string UnidadAbreviacion { get; set; } = null!;
        public int UnidadFactor { get; set; }
        public bool UnidadReferencia { get; set; }
        public decimal ProductoUnidadCostoPromedioSoles { get; set; }
        public decimal? Cpr { get; set; }
        public decimal? Cuc { get; set; }
        public string ListaPreciosSucursal { get; set; } = null!;
        public bool ItemModificado { get; set; }
        public int ItemUnidadDesde { get; set; }
        public int ItemUnidadHasta { get; set; }
        public decimal ItemUnidadPrecioIncImpto { get; set; }
        public decimal UnidadPrecioSinImpto { get; set; }
        public decimal ItemMargenNegociacionPorcentualA { get; set; }
        public decimal ItemMargenNegociacionPorcentualB { get; set; }
        public DateTime ItemFechaUltimaModificacion { get; set; }
        public DateTime ItemFechaVencimiento { get; set; }
        public bool ItemTieneFechaVencimiento { get; set; }
        public string ListaPreciosDescripcion { get; set; } = null!;
        public int ListaPreciosRedondeo { get; set; }
        public bool ListaPreciosActivo { get; set; }
        public decimal ListaPreciosTipoCambioCompra { get; set; }
        public decimal ListaPreciosTipoCambioVenta { get; set; }
        public string ItemProductoMoneda { get; set; } = null!;
        public bool ItemProductoUnidadEsVigente { get; set; }
    }
}
