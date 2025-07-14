using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDescuentoRecargoModalidadCredito2
    {
        public int DescuentosRecargosModalidadCreditoId { get; set; }
        public int IdlistaPrecios { get; set; }
        public string DescuentosRecargosModalidadCreditoDescuentoRecargo { get; set; } = null!;
        public int DescuentosRecargosModalidadCreditoIdmodalidadCredito { get; set; }
    }
}
