using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAuditorium
    {
        public long Id { get; set; }
        public string Usuario { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Pc { get; set; } = null!;
        public string Idtipo { get; set; } = null!;
        public string Identidad { get; set; } = null!;
        public string Idoperacion { get; set; } = null!;
    }
}
