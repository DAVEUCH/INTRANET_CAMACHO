using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TransaccionPendiente
    {
        public int Pkid { get; set; }
        public string? Documento { get; set; }
        public string? Contexto { get; set; }
        public DateTime? Hora { get; set; }
        public string? Error { get; set; }
        public int? NumeroIntentos { get; set; }
    }
}
