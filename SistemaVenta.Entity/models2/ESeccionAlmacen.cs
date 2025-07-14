using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ESeccionAlmacen
    {
        public int SeccionesId { get; set; }
        public string SeccionesDescripcion { get; set; } = null!;
        public int Idalmacen { get; set; }
    }
}
