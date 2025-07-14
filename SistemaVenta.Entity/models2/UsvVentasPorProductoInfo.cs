using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasPorProductoInfo
    {
        public string TipoCp { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int VendedorId { get; set; }
        public string VendedorNombre { get; set; } = null!;
        public int SucursalId { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public int ClienteId { get; set; }
        public string ClienteNombre { get; set; } = null!;
        public int? ProductoId { get; set; }
        public string? ProductoCodigo { get; set; }
        public string? ProductoDescripcion { get; set; }
        public int? MarcaId { get; set; }
        public string? MarcaDescripcion { get; set; }
        public int? ClaseProductoId { get; set; }
        public string? ClaseProductoDescripcion { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? Total { get; set; }
        public decimal? Cantidad { get; set; }
        public int? CantidadUnidadBase { get; set; }
        public int? FactorUnidadReferencia { get; set; }
        public string? AbreviacionUnidadReferencia { get; set; }
        public decimal? ValorVentaDolares { get; set; }
        public decimal? TotalDolares { get; set; }
    }
}
