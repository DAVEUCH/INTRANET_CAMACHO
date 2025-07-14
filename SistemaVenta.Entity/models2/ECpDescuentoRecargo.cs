using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECpDescuentoRecargo
    {
        public int CpDescuentosRecargosId { get; set; }
        public int Idcp { get; set; }
        public int CpDescuentosRecargosIdtipoDescuentoRecargo { get; set; }
        public string CpDescuentosRecargosCriterio { get; set; } = null!;
        public decimal CpDescuentosRecargosMonto { get; set; }
    }
}
