using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VImpresionOrdenCompraNess
    {
        public int Pkid { get; set; }
        public DateTime FechaEmision { get; set; }
        public string? SerieCp { get; set; }
        public string? NumeroCp { get; set; }
        public string ProveedorNombre { get; set; } = null!;
        public string ProveedorCodigo { get; set; } = null!;
        public decimal ItemCantidad { get; set; }
        public string ItemProductoDescripcionResumida { get; set; } = null!;
        public string ItemProductoCodigo { get; set; } = null!;
        public string ItemMarcaCodigo { get; set; } = null!;
        public decimal ItemPrecioUnitario { get; set; }
        public string Observacion { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string VendedorCodigo { get; set; } = null!;
        public int Moneda { get; set; }
    }
}
