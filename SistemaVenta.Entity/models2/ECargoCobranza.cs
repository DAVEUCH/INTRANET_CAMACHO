using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECargoCobranza
    {
        public int Id { get; set; }
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int IdtipoCp { get; set; }
        public int Idempleado { get; set; }
        public decimal Total { get; set; }
        public int IdplanillaCobranza { get; set; }
        public bool Cerrado { get; set; }
    }
}
