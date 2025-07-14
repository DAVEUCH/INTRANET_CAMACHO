using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteRegistroComprasReintegro
    {
        public int Idcp { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? ValorDescuento { get; set; }
        public decimal? ValorAfecto { get; set; }
        public decimal? ValorInafecto { get; set; }
        public decimal? ValorImpto { get; set; }
        public decimal? Total { get; set; }
        public int Reintegro { get; set; }
    }
}
