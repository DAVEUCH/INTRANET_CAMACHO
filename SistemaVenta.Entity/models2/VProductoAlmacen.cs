using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VProductoAlmacen
    {
        public string OrigenDestino { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Producto { get; set; } = null!;
        public string Unidad { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public int FactorUref { get; set; }
        public int Idalmacen { get; set; }
        public int Idproducto { get; set; }
        public int StockFisico { get; set; }
        public int StockContable { get; set; }
        public int StockPorEntregar { get; set; }
        public int StockPorRecibir { get; set; }
        public int? StockDisponible { get; set; }
        public bool Activo { get; set; }
        public string CodigoFabrica { get; set; } = null!;
        public int Pkid { get; set; }
    }
}
