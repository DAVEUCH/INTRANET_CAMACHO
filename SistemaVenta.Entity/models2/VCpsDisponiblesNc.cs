using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCpsDisponiblesNc
    {
        public int Id { get; set; }
        public string NumCp { get; set; } = null!;
        public int Idproducto { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? CantidadDisponible { get; set; }
        public int IditemCp { get; set; }
    }
}
