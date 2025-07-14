using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class LogErroresSql
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Evento { get; set; }
        public string? Detalles { get; set; }
    }
}
