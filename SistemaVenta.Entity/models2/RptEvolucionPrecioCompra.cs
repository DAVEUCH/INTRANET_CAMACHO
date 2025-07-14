using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RptEvolucionPrecioCompra
    {
        public int ProductoId { get; set; }
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoNombre { get; set; } = null!;
        public int UnidadRefId { get; set; }
        public string UnidadRefNombre { get; set; } = null!;
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public decimal? CostoUnitario { get; set; }
        public decimal TipoCambio { get; set; }
        public bool MonedaTipo { get; set; }
        public string MonedaNombre { get; set; } = null!;
        public string MonedaSimbolo { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int ClaseProductoId { get; set; }
        public string ClaseProductoNombre { get; set; } = null!;
    }
}
