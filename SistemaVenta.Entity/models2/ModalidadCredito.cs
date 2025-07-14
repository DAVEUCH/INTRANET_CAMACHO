using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ModalidadCredito
    {
        public ModalidadCredito()
        {
            CpCobrarPagars = new HashSet<CpCobrarPagar>();
            RecargoMcitemListaPrecios = new HashSet<RecargoMcitemListaPrecio>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int DiasCredito { get; set; }

        public virtual ICollection<CpCobrarPagar> CpCobrarPagars { get; set; }
        public virtual ICollection<RecargoMcitemListaPrecio> RecargoMcitemListaPrecios { get; set; }
    }
}
