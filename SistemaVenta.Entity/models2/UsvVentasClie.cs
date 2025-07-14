using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasClie
    {
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Total { get; set; }
    }
}
