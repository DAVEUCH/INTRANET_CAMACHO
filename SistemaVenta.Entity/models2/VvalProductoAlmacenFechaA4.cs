using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalProductoAlmacenFechaA4
    {
        public int Idalmacen { get; set; }
        public int Idproducto { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadFisico { get; set; }
        public int CantidadContable { get; set; }
        public int CantidadPorEntregar { get; set; }
        public int CantidadPorRecibir { get; set; }
        public int? CantidadFisicoFecha { get; set; }
        public int? CantidadContableFecha { get; set; }
        public int? CantidadPorEntregarFecha { get; set; }
        public int? CantidadPorRecibirFecha { get; set; }
    }
}
