using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptAlmapoConsolidadoDevolucionesAuxiliar2
    {
        public int ProductoId { get; set; }
        public int? DetalleProductoCantidadBase { get; set; }
        public string VendedorCodigo { get; set; } = null!;
    }
}
