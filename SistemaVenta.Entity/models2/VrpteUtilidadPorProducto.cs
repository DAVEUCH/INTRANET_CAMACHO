using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteUtilidadPorProducto
    {
        public string ProductoClase { get; set; } = null!;
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public int? ProductoCantidadUnidadBase { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? Costo { get; set; }
        public int Idperiodo { get; set; }
        public DateTime Fecha { get; set; }
        public string? ClaseProductoDescripcion { get; set; }
        public int? Pkid { get; set; }
    }
}
