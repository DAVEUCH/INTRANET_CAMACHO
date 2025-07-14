using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDescuentoRecargoModalidadCredito
    {
        public int IdlistaPrecios { get; set; }
        public int DescuentosRecargosModalidadCreditoIdmodalidadCredito { get; set; }
        public decimal DescuentosRecargosModalidadCreditoPorcentaje { get; set; }
        public string DescuentosRecargosModalidadCreditoDescuentoRecargo { get; set; } = null!;
        public int DescuentosRecargosModalidadCreditoId { get; set; }
    }
}
