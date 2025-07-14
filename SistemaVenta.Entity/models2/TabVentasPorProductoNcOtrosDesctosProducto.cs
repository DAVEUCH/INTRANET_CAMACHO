using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabVentasPorProductoNcOtrosDesctosProducto
    {
        public string NroNotaCredito { get; set; } = null!;
        public decimal ValorVentaNc { get; set; }
        public decimal TotalNc { get; set; }
        public int Idfact { get; set; }
        public string NroFactura { get; set; } = null!;
        public int? Idproducto { get; set; }
        public string? Codigo { get; set; }
        public decimal Cantidad { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal Total { get; set; }
        public int? NroItems { get; set; }
        public decimal? DescontarAlValorVenta { get; set; }
        public decimal? DescontarAlTotal { get; set; }
    }
}
