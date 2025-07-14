using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VSeleccionProductoCpCb2
    {
        public int Idalmacen { get; set; }
        public int Idunidad { get; set; }
        public string CodigoBarras { get; set; } = null!;
        public int Factor { get; set; }
        public int Idproducto { get; set; }
    }
}
