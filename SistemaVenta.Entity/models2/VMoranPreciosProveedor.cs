using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranPreciosProveedor
    {
        public int Idproveedor { get; set; }
        public string Nombre { get; set; } = null!;
        public int Idproducto { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Abreviacion { get; set; } = null!;
        public decimal Precio { get; set; }
        public decimal PrecioNetoImpto { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }
        public bool ArticuloCompra { get; set; }
        public bool Activo { get; set; }
        public int IdclaseProductoServicio { get; set; }
        public int CantidadMinimaCompra { get; set; }
        public int CantidadProduccion { get; set; }
        public string CodigoFabrica { get; set; } = null!;
        public decimal CostoPromedioDolares { get; set; }
        public decimal CostoPromedioSoles { get; set; }
        public decimal Stock { get; set; }
        public decimal StockPorRecibir { get; set; }
        public decimal StockPorEntregar { get; set; }
        public bool? EsInafecto { get; set; }
        public int FrecuenciaDeCompra { get; set; }
        public int TiempoDeEntrega { get; set; }
        public decimal DescuentoA { get; set; }
        public decimal DescuentoB { get; set; }
        public decimal DescuentoC { get; set; }
        public decimal DescuentoD { get; set; }
        public string Codigo { get; set; } = null!;
    }
}
