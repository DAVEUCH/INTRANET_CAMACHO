using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptUtilidadBrutaPorProveedor
    {
        public string CodigoProveedor { get; set; } = null!;
        public string NombreProveedor { get; set; } = null!;
        public string CodigoProducto { get; set; } = null!;
        public string NombreProducto { get; set; } = null!;
        public int StockActual { get; set; }
        public int StockComprometido { get; set; }
        public int? CantidadBaseVendida { get; set; }
        public string UnidadReferencia { get; set; } = null!;
        public int FactorUnidadReferencia { get; set; }
        public decimal? KardexValorado { get; set; }
        public decimal? TotalVenta { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? CostoVenta { get; set; }
        public DateTime Fecha { get; set; }
        public int Idalmacen { get; set; }
        public string Bonificacion { get; set; } = null!;
    }
}
