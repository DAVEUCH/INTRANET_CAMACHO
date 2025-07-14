using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EParametroEntradaBonificacion
    {
        public int ParametrosEntradaId { get; set; }
        public string ParametrosEntradaNombre { get; set; } = null!;
        public string ParametrosEntradaTipoDato { get; set; } = null!;
        public string ParametrosEntradaValor { get; set; } = null!;
        public int IdbonificacionHistorica { get; set; }
    }
}
