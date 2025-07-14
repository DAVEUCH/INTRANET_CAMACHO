using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemListaPreciosProveedor
    {
        public int Id { get; set; }
        public int IdlistaPreciosProveedor { get; set; }
        public int Idproducto { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioIncImpuesto { get; set; }
        public decimal DescuentoA { get; set; }
        public decimal DescuentoB { get; set; }
        public decimal DescuentoC { get; set; }
        public decimal DescuentoD { get; set; }
        public decimal PrecioNeto { get; set; }
        public decimal PrecioNetoImpto { get; set; }
        public int Idunidad { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }
    }
}
