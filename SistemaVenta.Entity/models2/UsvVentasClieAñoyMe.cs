using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasClieAñoyMe
    {
        public int ClienteId { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public decimal? Total { get; set; }
    }
}
