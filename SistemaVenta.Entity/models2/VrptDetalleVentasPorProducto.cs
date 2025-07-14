using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptDetalleVentasPorProducto
    {
        public DateTime Fecha { get; set; }
        public string NumCp { get; set; } = null!;
        public string Abreviacion { get; set; } = null!;
        public string OrigenDestinoNombre { get; set; } = null!;
        public int Idalmacen { get; set; }
        public int Idproducto { get; set; }
        public string Und { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public string CodigoProducto { get; set; } = null!;
        public string Producto { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public int Idmarca { get; set; }
        public decimal CostoUltimaCompraSoles { get; set; }
        public decimal CostoPromedioSoles { get; set; }
        public int Idsucursal { get; set; }
        public decimal? CostoVentaSoles { get; set; }
        public decimal? CostoVentaDolares { get; set; }
        public decimal? VentaSoles { get; set; }
        public decimal? VentaDolares { get; set; }
        public string CodigoVendedor { get; set; } = null!;
        public string Vendedor { get; set; } = null!;
        public int Idvendedor { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? CostoVenta { get; set; }
    }
}
