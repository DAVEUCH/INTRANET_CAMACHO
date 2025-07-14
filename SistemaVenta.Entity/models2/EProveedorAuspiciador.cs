using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EProveedorAuspiciador
    {
        public int Id { get; set; }
        public int Idproveedor { get; set; }
        public int Idbonificacion { get; set; }
        public decimal Desde { get; set; }
        public decimal Hasta { get; set; }
        public decimal CondicionDeRango { get; set; }
    }
}
