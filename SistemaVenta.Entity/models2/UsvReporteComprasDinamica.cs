using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvReporteComprasDinamica
    {
        public DateTime Fecha { get; set; }
        public string? SucursalNombre { get; set; }
        public string NumeroCp { get; set; } = null!;
        public string ProveedorNombre { get; set; } = null!;
        public int Idproducto { get; set; }
        public string CodigoProducto { get; set; } = null!;
        public string? CodigoInterno { get; set; }
        public string? Segmento { get; set; }
        public DateTime? FechaUltimaImportacion { get; set; }
        public string DescripcionProducto { get; set; } = null!;
        public string? AplicaProducto { get; set; }
        public string? MarcaDescripcion { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal CantidadComprada { get; set; }
        public string? NumeroDocVta { get; set; }
        public int? ClienteId { get; set; }
        public string? ClienteNombre { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? CantidadVendida { get; set; }
        public decimal? Var { get; set; }
        public string? Vendedor { get; set; }
        public decimal StockGrupo { get; set; }
        public string? NumeroGuia { get; set; }
    }
}
