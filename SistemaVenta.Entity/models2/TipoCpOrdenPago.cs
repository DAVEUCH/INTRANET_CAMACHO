using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoCpOrdenPago
    {
        public TipoCpOrdenPago()
        {
            CpOrdenPagos = new HashSet<CpOrdenPago>();
        }

        public int Pkid { get; set; }
        public string? EntradaSalida { get; set; }
        public bool? RequiereAprobacion { get; set; }

        public virtual TipoCp Pk { get; set; } = null!;
        public virtual ICollection<CpOrdenPago> CpOrdenPagos { get; set; }
    }
}
