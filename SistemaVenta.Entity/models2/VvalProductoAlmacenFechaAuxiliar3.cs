using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalProductoAlmacenFechaAuxiliar3
    {
        public DateTime Fecha { get; set; }
        public int Idalmacen { get; set; }
        public int Idproducto { get; set; }
        public int? CantidadFisicoFecha { get; set; }
        public int? CantidadContableFecha { get; set; }
        public int? CantidadPorEntregarFecha { get; set; }
        public int? CantidadPorRecibirFecha { get; set; }
        public int IdloteFabricacion { get; set; }
    }
}
