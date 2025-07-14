using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EProductoTomaInventario
    {
        public int ProductosId { get; set; }
        public int IdtomaInventario { get; set; }
        public int ProductosIdproducto { get; set; }
        public int ProductosCantidad { get; set; }
        public int ProductosStock { get; set; }
        public int ProductosDiferencia { get; set; }
        public int ProductosCantidadModificada { get; set; }
        public bool ProductosEditar { get; set; }
    }
}
