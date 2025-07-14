using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ELoteFabricacion
    {
        public int Id { get; set; }
        public int Idproducto { get; set; }
        public string Numero { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool Activo { get; set; }
    }
}
