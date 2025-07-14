using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EProductoObsequio2
    {
        public int ProductosObsequioId { get; set; }
        public int ProductosObsequioIdproducto { get; set; }
        public int ProductosObsequioIdunidad { get; set; }
        public int ProductosObsequioCantidad { get; set; }
        public int ProductosObsequioCantidadMaxima { get; set; }
        public int ProductosObsequioCantidadMaximaPorCliente { get; set; }
        public DateTime ProductosObsequioDesde { get; set; }
        public DateTime ProductosObsequioHasta { get; set; }
        public bool ProductosObsequioTieneStock { get; set; }
        public decimal ProductosObsequioStock { get; set; }
        public bool ProductosObsequioTieneCantidadPorCliente { get; set; }
        public int IddefinicionBonificacion { get; set; }
        public decimal ProductosObsequioStockPorEntregar { get; set; }
        public decimal ProductosObsequioStockEntregado { get; set; }
    }
}
