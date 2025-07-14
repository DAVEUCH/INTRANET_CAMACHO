using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvAlmacenesDetalle
    {
        public string Almacen { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string? CodigoInterno { get; set; }
        public string Descripcion { get; set; } = null!;
        public int StockFisico { get; set; }
        public int StockContable { get; set; }
        public string? Clase { get; set; }
        public string Marca { get; set; } = null!;
        public string? Segmento { get; set; }
        public DateTime? UltFechaCompra { get; set; }
        public DateTime? UltFechaVenta { get; set; }
        public string? Caracteristica1 { get; set; }
        public string? Caracteristica2 { get; set; }
        public string? Caracteristica3 { get; set; }
        public string? Caracteristica4 { get; set; }
        public string? Caracteristica5 { get; set; }
        public string? Caracteristica6 { get; set; }
        public string? Caracteristica7 { get; set; }
        public string? Caracteristica8 { get; set; }
        public string? Caracteristica9 { get; set; }
        public string? Caracteristica10 { get; set; }
        public bool Activo { get; set; }
    }
}
