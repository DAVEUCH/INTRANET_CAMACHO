using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemCpImpuesto
    {
        public int Pkid { get; set; }
        public decimal PorcentajeImpto { get; set; }
        public decimal Total { get; set; }
        public decimal ValorVenta { get; set; }
        public bool Bonificacion { get; set; }
        public bool Inafecto { get; set; }
    }
}
