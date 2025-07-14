using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EMovimientoCuentaBanco
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public DateTime FechaImportacion { get; set; }
        public int Idcaja { get; set; }
        public string Moneda { get; set; } = null!;
        public int? Idmoneda { get; set; }
    }
}
