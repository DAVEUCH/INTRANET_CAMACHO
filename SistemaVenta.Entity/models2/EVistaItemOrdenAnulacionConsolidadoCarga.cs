using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EVistaItemOrdenAnulacionConsolidadoCarga
    {
        public int Id { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public string TipoCpAbreviacion { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public string ClienteNombre { get; set; } = null!;
        public bool AnulacionTotal { get; set; }
        public string EstadoEjecucion { get; set; } = null!;
        public string ResponsableCodigo { get; set; } = null!;
        public string ResponsableNombre { get; set; } = null!;
        public decimal Total { get; set; }
        public int Pkid { get; set; }
        public int ItemOrdenAnulacionConsolidadoCargaId { get; set; }
        public int ItemOrdenAnulacionConsolidadoCargaIdordenAnulacion { get; set; }
        public int ItemOrdenAnulacionConsolidadoCargaIdconsolidadoCarga { get; set; }
        public int IdordenAnulacion { get; set; }
    }
}
