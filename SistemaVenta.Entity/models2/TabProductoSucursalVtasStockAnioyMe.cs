using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabProductoSucursalVtasStockAnioyMe
    {
        public int? Idsucursal { get; set; }
        public int? Idproducto { get; set; }
        public string? CodProducto { get; set; }
        public int? Anio { get; set; }
        public int? Mes { get; set; }
        public int? SaldoInicial { get; set; }
        public int? SaldoFinal { get; set; }
        public int? Ventas { get; set; }
        public int? ReqMat { get; set; }
        public int? Cp { get; set; }
        public int? Gci { get; set; }
    }
}
