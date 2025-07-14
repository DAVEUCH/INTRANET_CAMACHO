using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TarjetaCredito
    {
        public int Pkid { get; set; }
        public int IdoperadorTarjetaCredito { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual OperadorTarjetaCredito IdoperadorTarjetaCreditoNavigation { get; set; } = null!;
    }
}
