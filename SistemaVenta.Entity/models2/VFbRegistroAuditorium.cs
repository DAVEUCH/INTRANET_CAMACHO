using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VFbRegistroAuditorium
    {
        public long Id { get; set; }
        public string Usuario { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Pc { get; set; } = null!;
        public string Identidad { get; set; } = null!;
        public string NombreTipo { get; set; } = null!;
        public string? ContenidoXml { get; set; }
    }
}
