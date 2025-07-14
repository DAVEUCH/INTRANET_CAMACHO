using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ParametroEntradaBonificacion
    {
        public int Pkid { get; set; }
        public string Nombre { get; set; } = null!;
        public string TipoDato { get; set; } = null!;
        public string Valor { get; set; } = null!;
        public int IdbonificacionHistorica { get; set; }

        public virtual BonificacionHistorica IdbonificacionHistoricaNavigation { get; set; } = null!;
    }
}
