using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvItemValorPorDefectoCaja
    {
        public string Pkid { get; set; } = null!;
        public string IdvalorPorDefecto { get; set; } = null!;
        public int? ValorCaja { get; set; }
    }
}
