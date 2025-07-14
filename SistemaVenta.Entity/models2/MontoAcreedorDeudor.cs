using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class MontoAcreedorDeudor
    {
        public int Id { get; set; }
        public int IdtipoPersona { get; set; }
        public string CobrarPagar { get; set; } = null!;
        public int EsAcreedorDeudor { get; set; }
    }
}
