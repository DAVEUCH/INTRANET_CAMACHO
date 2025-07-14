using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInventarioFisico
    {
        public string Linea { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int? Factor { get; set; }
        public int StockFisico { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Tcp { get; set; }
        public decimal? Tuc { get; set; }
        public decimal? Cpc { get; set; }
        public decimal? Cuc { get; set; }
        public string Almacen { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public bool Activo { get; set; }
    }
}
