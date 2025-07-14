using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RVentasPorSucursal
    {
        public string CodigoSucursal { get; set; } = null!;
        public string Sucursal { get; set; } = null!;
        public string CodigoAlmacen { get; set; } = null!;
        public string Almacen { get; set; } = null!;
        public decimal? Total { get; set; }
        public DateTime Fecha { get; set; }
        public int Idsucursal { get; set; }
        public int Idalmacen { get; set; }
    }
}
