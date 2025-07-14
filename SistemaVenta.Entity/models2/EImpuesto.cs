using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EImpuesto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Abreviacion { get; set; } = null!;
        public decimal Valor { get; set; }
        public bool AplicableAproducto { get; set; }
        public bool Retencion { get; set; }
    }
}
