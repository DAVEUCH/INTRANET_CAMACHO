using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VmoranListaprecio
    {
        public int IdlistaPrecios { get; set; }
        public string ListaPrecios { get; set; } = null!;
        public string ProductoCodigo { get; set; } = null!;
        public string? ProductoDescripcion { get; set; }
        public string UnidadBase { get; set; } = null!;
        public decimal PrecioBase { get; set; }
        public string? UnidadReferencia { get; set; }
        public decimal? PrecioReferencial { get; set; }
        public bool Bonificacion { get; set; }
        public string? Categoria { get; set; }
        public string Prefijo { get; set; } = null!;
        public int PrefijoId { get; set; }
        public string Marca { get; set; } = null!;
        public string Linea { get; set; } = null!;
        public string SucursalNombre { get; set; } = null!;
        public string SucursalDireccion { get; set; } = null!;
        public string SucursalCodigo { get; set; } = null!;
        public int SucursalId { get; set; }
        public string Proveedor { get; set; } = null!;
        public int CategoriaId { get; set; }
        public int ProveedorId { get; set; }
        public string Linea1 { get; set; } = null!;
        public string Linea2 { get; set; } = null!;
        public DateTime? FechaReporte { get; set; }
    }
}
