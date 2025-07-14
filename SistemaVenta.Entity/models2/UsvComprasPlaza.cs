using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvComprasPlaza
    {
        public DateTime Fecha { get; set; }
        public string Sucursal { get; set; } = null!;
        public string Numerocp { get; set; } = null!;
        public int Idproducto { get; set; }
        public int Idsucursal { get; set; }
        public string Codigoproducto { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal? Costo { get; set; }
        public decimal? CostoaSoles { get; set; }
        public string EstadoFacturacion { get; set; } = null!;
        public decimal? UltimaCostoCompraaSoles { get; set; }
        public string? Vendedor { get; set; }
        public string? Proveedor { get; set; }
    }
}
