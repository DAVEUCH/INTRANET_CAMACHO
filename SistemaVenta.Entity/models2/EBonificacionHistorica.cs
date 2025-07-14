using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EBonificacionHistorica
    {
        public int Id { get; set; }
        public string Procedimiento { get; set; } = null!;
        public string? EnlaceHistorico { get; set; }
    }
}
