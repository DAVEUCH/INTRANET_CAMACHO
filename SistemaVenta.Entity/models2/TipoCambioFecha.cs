using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoCambioFecha
    {
        public int Pkid { get; set; }
        public int Idmoneda { get; set; }
        public decimal TipoCambioCompra { get; set; }
        public decimal TipoCambioVenta { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Monedum IdmonedaNavigation { get; set; } = null!;
    }
}
