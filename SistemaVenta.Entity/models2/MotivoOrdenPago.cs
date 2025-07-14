using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class MotivoOrdenPago
    {
        public MotivoOrdenPago()
        {
            CpOrdenPagos = new HashSet<CpOrdenPago>();
        }

        public int Pkid { get; set; }
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<CpOrdenPago> CpOrdenPagos { get; set; }
    }
}
