using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RecargoMcitemListaPrecio
    {
        public int Pkid { get; set; }
        public int IditemListaPrecios { get; set; }
        public int IdmodalidadCredito { get; set; }
        public decimal Porcentaje { get; set; }
        public string DescuentoRecargo { get; set; } = null!;

        public virtual ModalidadCredito IdmodalidadCreditoNavigation { get; set; } = null!;
    }
}
