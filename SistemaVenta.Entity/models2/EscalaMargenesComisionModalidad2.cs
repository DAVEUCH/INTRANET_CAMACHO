using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EscalaMargenesComisionModalidad2
    {
        public int Pkid { get; set; }
        public decimal Desde { get; set; }
        public decimal Hasta { get; set; }
        public decimal Afecto { get; set; }
        public decimal Inafecto { get; set; }
    }
}
