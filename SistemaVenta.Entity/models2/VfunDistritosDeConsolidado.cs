using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VfunDistritosDeConsolidado
    {
        public int ConsolidadoId { get; set; }
        public string ConsolidadoNumero { get; set; } = null!;
        public DateTime ConsolidadoFecha { get; set; }
        public string ClienteNombre { get; set; } = null!;
        public int ClienteId { get; set; }
        public int CpVentaId { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool DireccionPrincipal { get; set; }
        public int Iddistrito { get; set; }
        public string DistritoNombre { get; set; } = null!;
    }
}
