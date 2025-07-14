using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EHoraDium
    {
        public int HorasId { get; set; }
        public int IddiaHorario { get; set; }
        public string HorasHora { get; set; } = null!;
    }
}
