using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptVentasxProducto
    {
        public DateTime Fecha { get; set; }
        public string CodigoProducto { get; set; } = null!;
        public string Producto { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public decimal? Cantidad { get; set; }
        public decimal? ValorUnitario { get; set; }
        public decimal? Total { get; set; }
        public string CodigoVendedor { get; set; } = null!;
        public string Vendedor { get; set; } = null!;
        public int Idalmacen { get; set; }
        public int Idproducto { get; set; }
        public int Idvendedor { get; set; }
        public int Idsucursal { get; set; }
        public int? Idproveedor { get; set; }
        public decimal Stock { get; set; }
    }
}
