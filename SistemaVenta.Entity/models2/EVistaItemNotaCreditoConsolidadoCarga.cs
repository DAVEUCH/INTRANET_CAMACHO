using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EVistaItemNotaCreditoConsolidadoCarga
    {
        public int Id { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public string TipoCpAbreviacion { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public string? PersonaNombre { get; set; }
        public bool Credito { get; set; }
        public decimal? Total { get; set; }
        public string ResponsableCodigo { get; set; } = null!;
        public string ResponsableNombre { get; set; } = null!;
        public bool Anulado { get; set; }
        public int IdnotaCredito { get; set; }
        public int Pkid { get; set; }
        public int ItemNotaCreditoConsolidadoCargaId { get; set; }
        public int ItemNotaCreditoConsolidadoCargaIdconsolidadoCarga { get; set; }
        public int ItemNotaCreditoConsolidadoCargaIdnotaCredito { get; set; }
        public decimal MontoPercepcion { get; set; }
    }
}
