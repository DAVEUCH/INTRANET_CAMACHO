using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvNumeroDocsVentaEmiten
    {
        public string Nombre { get; set; } = null!;
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int? Cant { get; set; }
    }
}
