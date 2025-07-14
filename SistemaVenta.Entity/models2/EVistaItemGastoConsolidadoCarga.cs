using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EVistaItemGastoConsolidadoCarga
    {
        public int Id { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public string TipoCpAbreviacion { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public string PersonaNombre { get; set; } = null!;
        public decimal TotalSoles { get; set; }
        public decimal TotalDolares { get; set; }
        public int Pkid { get; set; }
        public int ItemGastoConsolidadoCargaId { get; set; }
        public int ItemGastoConsolidadoCargaIdconsolidadoCarga { get; set; }
        public int ItemGastoConsolidadoCargaIdgasto { get; set; }
    }
}
