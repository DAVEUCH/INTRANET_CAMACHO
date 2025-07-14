using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EActividadesPendiente
    {
        public int Id { get; set; }
        public string Estado { get; set; } = null!;
        public int Prioridad { get; set; }
        public string Codigo { get; set; } = null!;
    }
}
