using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EProductoAgrupacion
    {
        public int ProductoProductosId { get; set; }
        public int ProductoIdproductoPadre { get; set; }
        public int ProductoProductosIdproducto { get; set; }
        public int ProductoProductosIdunidad { get; set; }
        public decimal ProductoProductosCantidad { get; set; }
        public int Id { get; set; }
        public int IdproductoPadre { get; set; }
        public int Idproducto { get; set; }
        public decimal Cantidad { get; set; }
        public int Idunidad { get; set; }
        public int NumeroItem { get; set; }
        public int ProductoProductosNumeroItem { get; set; }
        public decimal? ProductoProductosPorcentaje { get; set; }
    }
}
