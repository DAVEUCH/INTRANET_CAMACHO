using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ERecargoMcitemListaPrecio
    {
        public int RecargosModalidadCreditoId { get; set; }
        public int IditemListaPrecios { get; set; }
        public int RecargosModalidadCreditoIdmodalidadCredito { get; set; }
        public decimal RecargosModalidadCreditoPorcentaje { get; set; }
        public string RecargosModalidadCreditoDescuentoRecargo { get; set; } = null!;
    }
}
