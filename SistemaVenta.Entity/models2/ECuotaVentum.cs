using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECuotaVentum
    {
        public int Id { get; set; }
        public string Mes { get; set; } = null!;
        public string Año { get; set; } = null!;
    }
}
