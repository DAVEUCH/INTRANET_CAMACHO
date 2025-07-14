using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EEscalaProductoAgrupacion
    {
        public int ProductosAgrupacionId { get; set; }
        public decimal ProductosAgrupacionPrecio { get; set; }
        public bool ProductosAgrupacionBonificacion { get; set; }
        public int ProductosAgrupacionIdproductoAgrupacion { get; set; }
        public int Idescala { get; set; }
        public int Id { get; set; }
        public decimal ProductosAgrupacionPorcentaje { get; set; }
    }
}
