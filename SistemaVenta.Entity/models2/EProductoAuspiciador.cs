using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EProductoAuspiciador
    {
        public int ProductosAuspiciadorId { get; set; }
        public int ProductosAuspiciadorIdproducto { get; set; }
        public int ProductosAuspiciadorIdunidad { get; set; }
        public int Idbonificacion { get; set; }
        public bool ProductosAuspiciadorIncluyeAfines { get; set; }
        public bool ProductosAuspiciadorPorMonto { get; set; }
        public bool ProductosAuspiciadorUnidadExclusiva { get; set; }
        public decimal ProductosAuspiciadorDesde { get; set; }
        public decimal ProductosAuspiciadorHasta { get; set; }
        public decimal ProductosAuspiciadorCondicionDeRango { get; set; }
    }
}
