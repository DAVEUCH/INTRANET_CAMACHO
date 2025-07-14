using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EVistaItemPercepcionConsolidadoCarga2
    {
        public int Id { get; set; }
        public string Abreviacion { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public decimal Total { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public int Pkid { get; set; }
        public int ItemPercepcionConsolidadoCarga2IdconsolidadoCarga { get; set; }
        public int ItemPercepcionConsolidadoCarga2Idpercepcion { get; set; }
        public int ItemPercepcionConsolidadoCarga2Id { get; set; }
    }
}
