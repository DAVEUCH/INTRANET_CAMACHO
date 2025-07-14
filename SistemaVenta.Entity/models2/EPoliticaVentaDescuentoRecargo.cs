using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EPoliticaVentaDescuentoRecargo
    {
        public int CpDescuentosRecargosIdtipoDescuentoRecargo { get; set; }
        public decimal CpDescuentosRecargosMonto { get; set; }
        public int CpDescuentosRecargosId { get; set; }
        public string CpDescuentosRecargosCriterio { get; set; } = null!;
        public int Idcp { get; set; }
    }
}
