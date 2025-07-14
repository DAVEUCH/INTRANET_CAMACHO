using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class MoranCalificativo
    {
        public int Pkid { get; set; }
        public int Desde { get; set; }
        public int Hasta { get; set; }
        public string Calificativo { get; set; } = null!;
        public string CondicionCredito { get; set; } = null!;
    }
}
