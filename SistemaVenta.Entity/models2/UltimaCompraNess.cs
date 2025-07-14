using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UltimaCompraNess
    {
        public string It { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Referencial { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Aplicacion { get; set; } = null!;
        public decimal CostoUltimaCompra { get; set; }
        public decimal Cantidad { get; set; }
        public int? Stock { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioVentaIgv { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
