using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptDetalleDeCompra
    {
        public string CodigoProducto { get; set; } = null!;
        public string Producto { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string Unidad { get; set; } = null!;
        public decimal? TotalItem { get; set; }
        public decimal CostoUltimaCompraSoles { get; set; }
        public decimal CostoPromedioSoles { get; set; }
        public int Pkid { get; set; }
        public DateTime Fecha { get; set; }
        public int Idsucursal { get; set; }
        public decimal Cantidad { get; set; }
        public int Idmarca { get; set; }
        public int Idproducto { get; set; }
    }
}
