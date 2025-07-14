using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EEjercicio
    {
        public int Id { get; set; }
        public string Año { get; set; } = null!;
        public bool Activo { get; set; }
        public bool Cerrado { get; set; }
    }
}
