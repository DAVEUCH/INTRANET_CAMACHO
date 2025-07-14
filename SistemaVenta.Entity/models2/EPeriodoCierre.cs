using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EPeriodoCierre
    {
        public int NivelesId { get; set; }
        public int Idperiodo { get; set; }
        public string NivelesIdtipoAsociado { get; set; } = null!;
        public string NivelesIdentidad { get; set; } = null!;
        public bool NivelesCerrado { get; set; }
        public string NivelesDescripcion { get; set; } = null!;
    }
}
