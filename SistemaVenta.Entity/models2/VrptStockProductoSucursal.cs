using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptStockProductoSucursal
    {
        public int Idproducto { get; set; }
        public int Idsucursal { get; set; }
        public int? Idproveedor { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int? Stock { get; set; }
        public string Sucursal { get; set; } = null!;
        public int Factor { get; set; }
        public string Abreviacion { get; set; } = null!;
        public int Idmarca { get; set; }
        public decimal CostoReferenciaSoles { get; set; }
    }
}
