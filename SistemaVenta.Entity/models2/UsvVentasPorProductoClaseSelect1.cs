using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasPorProductoClaseSelect1
    {
        public int Pkid { get; set; }
        public string NumCp { get; set; } = null!;
        public string TipoCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public int VendedorId { get; set; }
        public int? ProductoId { get; set; }
        public int? IdclaseProductoServicio { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? Total { get; set; }
        public decimal? Cantidad { get; set; }
        public int? CantidadUnidadBase { get; set; }
        public int? FactorUnidadReferencia { get; set; }
        public string? AbreviacionUnidadReferencia { get; set; }
        public string? ClaseCodigo { get; set; }
        public string? ClaseDescripcion { get; set; }
    }
}
