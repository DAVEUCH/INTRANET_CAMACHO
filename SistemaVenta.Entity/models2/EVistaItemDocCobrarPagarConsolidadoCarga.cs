using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EVistaItemDocCobrarPagarConsolidadoCarga
    {
        public int Id { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public int Idcp { get; set; }
        public string TipoCpAbreviacion { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public string PersonaNombre { get; set; } = null!;
        public bool Credito { get; set; }
        public decimal Total { get; set; }
        public decimal Saldo { get; set; }
        public string ResponsableCodigo { get; set; } = null!;
        public string ResponsableNombre { get; set; } = null!;
        public int Pkid { get; set; }
        public int ItemDocCobrarPagarConsolidadoCargaId { get; set; }
        public int ItemDocCobrarPagarConsolidadoCargaIdconsolidadoCarga { get; set; }
        public int ItemDocCobrarPagarConsolidadoCargaIddocCobrarPagar { get; set; }
    }
}
