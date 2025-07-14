using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EBanco
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Codigo { get; set; } = null!;
    }
}
