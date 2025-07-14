using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDescuentoRecargo
    {
        public int IdlistaPrecio { get; set; }
        public int DescuentosRecargosIdtipoMedioDePago { get; set; }
        public decimal DescuentosRecargosPorcentaje { get; set; }
        public string DescuentosRecargosDescuentoRecargo { get; set; } = null!;
    }
}
