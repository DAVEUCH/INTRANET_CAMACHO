using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteUtilidadPorProducto2
    {
        public int SucursalId { get; set; }
        public string SucursalCodigo { get; set; } = null!;
        public string SucursalNombre { get; set; } = null!;
        public int CategoriaId { get; set; }
        public string CategoriaCodigo { get; set; } = null!;
        public string CategoriaDescripcion { get; set; } = null!;
        public int ZonaId { get; set; }
        public string ZonaCodigo { get; set; } = null!;
        public string ZonaDescripcion { get; set; } = null!;
        public int FuerzaVentasId { get; set; }
        public string FuerzaVentasCodigo { get; set; } = null!;
        public string FuerzaVentasNombre { get; set; } = null!;
        public int TipoClienteId { get; set; }
        public string TipoClienteCodigo { get; set; } = null!;
        public string TipoClienteDescripcion { get; set; } = null!;
        public int ClienteId { get; set; }
        public string ClienteCodigo { get; set; } = null!;
        public string ClienteNombre { get; set; } = null!;
        public int ProductoId { get; set; }
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public int MarcaId { get; set; }
        public string MarcaCodigo { get; set; } = null!;
        public string MarcaDescripcion { get; set; } = null!;
        public int ProveedorId { get; set; }
        public string ProveedorCodigo { get; set; } = null!;
        public string ProveedorNombre { get; set; } = null!;
        public int ClaseProductoId { get; set; }
        public string ClaseProductoCodigo { get; set; } = null!;
        public string ClaseProductoDescripcion { get; set; } = null!;
        public int VendedorId { get; set; }
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public decimal? ValorVenta { get; set; }
        public decimal? Total { get; set; }
        public int? CantidadUnidadBase { get; set; }
        public decimal? Costo { get; set; }
        public DateTime Fecha { get; set; }
        public int Factor { get; set; }
    }
}
