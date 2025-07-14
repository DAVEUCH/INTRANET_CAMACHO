using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class PeriodoCierre
    {
        public int Pkid { get; set; }
        public int Idperiodo { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public string Identidad { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool Cerrado { get; set; }

        public virtual Periodo IdperiodoNavigation { get; set; } = null!;
    }
}
