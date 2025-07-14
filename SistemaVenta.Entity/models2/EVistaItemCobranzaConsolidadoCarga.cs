using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EVistaItemCobranzaConsolidadoCarga
    {
        public int Id { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public string TipoCpAbreviacion { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public decimal TotalSoles { get; set; }
        public decimal TotalDolares { get; set; }
        public int Pkid { get; set; }
        public int ItemCobranzaConsolidadoCargaId { get; set; }
        public int ItemCobranzaConsolidadoCargaIdconsolidadoCarga { get; set; }
        public int ItemCobranzaConsolidadoCargaIdcobranza { get; set; }
    }
}
