using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasPorProductoClaseSelect
    {
        public int Pkid { get; set; }
        public string NumCp { get; set; } = null!;
        public string TipoCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public string ClienteNombre { get; set; } = null!;
        public int? ProductoId { get; set; }
        public string? ClasePadreDescripcion { get; set; }
        public int? ClaseId { get; set; }
        public string? ClaseCodigo { get; set; }
        public string? ClaseDescripcion { get; set; }
        public int? VendedorId { get; set; }
        public string? VendedorNombre { get; set; }
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
