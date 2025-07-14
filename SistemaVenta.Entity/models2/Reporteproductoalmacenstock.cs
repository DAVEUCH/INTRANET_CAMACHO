using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Reporteproductoalmacenstock
    {
        public string Almacen { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int StockFisico { get; set; }
        public int? StockContable { get; set; }
    }
}
