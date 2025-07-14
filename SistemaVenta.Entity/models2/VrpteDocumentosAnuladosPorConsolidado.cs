using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteDocumentosAnuladosPorConsolidado
    {
        public string Abreviacion { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string? MotivoAnulacion { get; set; }
        public string Consolidado { get; set; } = null!;
        public string Transporte { get; set; } = null!;
        public string Vendedor { get; set; } = null!;
    }
}
